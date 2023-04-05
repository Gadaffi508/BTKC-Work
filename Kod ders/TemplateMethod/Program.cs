// See https://aka.ms/new-console-template for more information
using static System.Formats.Asn1.AsnWriter;

namespace TemplateMethod
{
    class Template
    {
        static void Main(string[] args)
        {
            ScoringAlgoritma algoritma;
            Console.WriteLine("Mans");
            algoritma = new MensScoringAlgoritma();
            Console.WriteLine(algoritma.GenerateScore(10,new TimeSpan(0,2,34)));

            Console.WriteLine("Womens");
            algoritma = new WomensScoringAlgoritma();
            Console.WriteLine(algoritma.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Childrens");
            algoritma = new ChildrensScoringAlgoritma();
            Console.WriteLine(algoritma.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.ReadLine();
        }
    }
    abstract class ScoringAlgoritma
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverAllScore(score,reduction);
        }

        public abstract int CalculateBaseScore(int hits);
        public abstract int CalculateOverAllScore(int score,int reduction);
        public abstract int CalculateReduction(TimeSpan time);
    }
    class MensScoringAlgoritma : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }
    class WomensScoringAlgoritma : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
    class ChildrensScoringAlgoritma : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 80;
        }

        public override int CalculateOverAllScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }
}
