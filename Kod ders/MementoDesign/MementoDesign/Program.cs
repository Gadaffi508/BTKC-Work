// See https://aka.ms/new-console-template for more information
namespace MementoDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                İsbn = "123",
                Title = "Yusuf",
                Author = " Arslan "
            };
            book.ShowBook();
            CareTaker careTaker = new CareTaker();
            careTaker.Memento = book.Createundo();

            book.İsbn = "321";
            book.Title = "Fusuy";

            book.ShowBook();

            book.RestoreFromUndo(careTaker.Memento);
            book.ShowBook();

            Console.ReadLine();
        }
    }
    class Book
    {
        private string _Title { get; set; }
        private string _Author { get; set; }
        private string _isbn { get; set; }
        private DateTime _lastEdaited;
        public string Title
        {
            get { return _Title; }
            set 
            {
                _Title = value;
                SetLastEdited();
            }
        }
        public string Author
        {
            get { return _Author; }
            set
            { 
                _Author = value;
                SetLastEdited();
            }
        }
        public string İsbn
        {
            get { return _isbn; }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited()
        {
            _lastEdaited=DateTime.UtcNow;
        }
        public Memento Createundo()
        {
            return new Memento(_isbn,_Title,_Author,_lastEdaited);
        }
        public void RestoreFromUndo(Memento memento)
        {
            _Title=memento.Title;
            _Author=memento.Author;
            _isbn=memento.Isbn;
            _lastEdaited=memento.LastEdaited;
        }
        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2} edited : {3}",İsbn,Title,Author,_lastEdaited);
        }
    }
    class Memento
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime LastEdaited { get; set; }
        
        public Memento(string isbn,string title,string author,DateTime lastEdited)
        {
            Isbn = isbn;
            Title = title;
            Author = author;
            LastEdaited = lastEdited;
        }
    }
    class CareTaker
    {
        public Memento Memento { get; set; }
    }
}
