// See https://aka.ms/new-console-template for more information
namespace CommandDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            BuyStock buyStock = new BuyStock(stockManager);
            SellStock sellStock = new SellStock(stockManager);

            StockControl stockControl = new StockControl();
            stockControl.TakeOrder(buyStock);
            stockControl.TakeOrder(sellStock);
            stockControl.TakeOrder(buyStock);

            stockControl.PlaceOrders();

            Console.ReadLine();
        }
    }
    class StockManager
    {
        private string _name = "Laptop";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock : {0}, {1} bought !",_name,_quantity);
        }

        public void Sell()
        {
            Console.WriteLine("Stock : {0}, {1} sold !", _name, _quantity);
        }
    }
    interface IOrder
    {
        void Execute();
    }
    class BuyStock : IOrder
    {
        private StockManager _stockManager;
        public BuyStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Buy();
        }
    }
    class SellStock : IOrder
    {
        private StockManager _stockManager;
        public SellStock(StockManager stockManager)
        {
            _stockManager = stockManager;
        }
        public void Execute()
        {
            _stockManager.Sell();
        }
    }
    class StockControl
    {
        List<IOrder> _orders = new List<IOrder>();
        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }
        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }
    }
}
