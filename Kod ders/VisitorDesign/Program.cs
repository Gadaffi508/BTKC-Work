// See https://aka.ms/new-console-template for more information
namespace VisitorDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager yusuf = new Manager { Name = "Yusuf",Salary=10000};
            Manager eda = new Manager { Name = "Eda",Salary = 9000};

            Worker pınar = new Worker { Name = "Pınar", Salary = 5000};
            Worker nesli = new Worker { Name = "Nesli",Salary = 5250};

            yusuf.Subordinates.Add(eda);
            eda.Subordinates.Add(pınar);
            eda.Subordinates.Add(nesli);

            OrganisationalStructure organisationalStructure = new OrganisationalStructure(yusuf);

            PayrollVisitor payroll = new PayrollVisitor();
            Payrise payrise = new Payrise();

            organisationalStructure.Accept(payroll);
            organisationalStructure.Accept(payrise);

            Console.ReadLine();
        }
    }
    class OrganisationalStructure
    {
        public EmployeeBase _employeeBase;

        public OrganisationalStructure (EmployeeBase firstEmployee)
        {
            _employeeBase = firstEmployee;
        }

        public void Accept(VisitorBase visitorBase)
        {
            _employeeBase.Accept(visitorBase);
        }

    }
    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitorBase);
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    class Manager : EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public List<EmployeeBase> Subordinates { get; set; }

        public override void Accept(VisitorBase visitorBase)
        {
            visitorBase.Visit(this);

            foreach (var employee in Subordinates)
            {
                employee.Accept(visitorBase);
            }
        }
    }
    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitorBase)
        {
            visitorBase.Visit(this);
        }
    }
    abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }
    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}",worker.Name,worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }
    }
    class Payrise : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary*(decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}", manager.Name, manager.Salary * (decimal)1.2);
        }
    }
}
