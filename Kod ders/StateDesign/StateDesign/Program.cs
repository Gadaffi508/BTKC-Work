// See https://aka.ms/new-console-template for more information
namespace StateDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            ModifiedState modified = new ModifiedState();
            modified.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            Console.ReadLine();
        }
    }
    interface IState
    {
        void DoAction(Context context);
    }
    class ModifiedState:IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Modified");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Modified";
        }
    }
    class DeletedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Deleted");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Deleted";
        }
    }
    class AddedState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("State : Added");
            context.SetState(this);
        }
        public override string ToString()
        {
            return "Added";
        }
    }
    internal class Context
    {
        private IState _state;
        public void SetState(IState state)
        {
            _state=state;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}
