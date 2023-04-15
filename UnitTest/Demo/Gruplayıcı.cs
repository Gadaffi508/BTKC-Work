namespace Demo
{
    public class Gruplayıcı
    {
        private int v;

        public Gruplayıcı(int v)
        {
            this.v = v;
        }

        internal List<List<Olcum>> Grupla(List<Olcum> olcumler)
        {
            var gruplar = new List<List<Olcum>>();
            gruplar.Add(olcumler);
            return gruplar;
        }
    }
}