using System;

namespace ProgressionsDemo
{
    public abstract class Progressii
    {
        // первый член прогрессии
        protected double a;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public Progressii(double firstTerm, string name = "DefaultProgression", string description = "No description")
        {
            a = firstTerm;
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public abstract double GetNthTerm(int n);

        public virtual bool IsDecreasing()
        {
            return GetNthTerm(2) < GetNthTerm(1);
        }
    }

    // Класс арифметической прогрессии
    public class ArithmeticProgression : Progressii
    {
        public double d; // Разность прогрессии

        public ArithmeticProgression(double firstTerm, double difference, string name = "ArithmeticProgression", string description = "Arithmetic progression")
            : base(firstTerm, name, description)
        {
            d = difference;
        }

        public override double GetNthTerm(int n)
        {
            return a + (n - 1) * d;
        }

        // n/2 * (2*a + (n-1)*d)
        private double Sum(int n)
        {
            return n * (2 * a + (n - 1) * d) / 2.0;
        }

        public static double operator +(ArithmeticProgression prog, int n)
        {
            return prog.Sum(n);
        }
    }

    public class GeometricProgression : Progressii
    {
        public double r; // Знаменатель (общий множитель)

        public GeometricProgression(double firstTerm, double ratio, string name = "GeometricProgression", string description = "Geometric progression")
            : base(firstTerm, name, description)
        {
            r = ratio;
        }

        // a * r^(n-1)
        public override double GetNthTerm(int n)
        {
            return a * Math.Pow(r, n - 1);
        }

        // Если r == 1, то сумма равна n*a, иначе: a*(1 - r^n)/(1 - r)
        private double Sum(int n)
        {
            if (r == 1) return n * a;
            return a * (1 - Math.Pow(r, n)) / (1 - r);
        }

        public static double operator *(GeometricProgression prog, int n)
        {
            return prog.Sum(n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression ap = new ArithmeticProgression(
                firstTerm: 2,
                difference: 3,
                name: "AP Example",
                description: "Арифметическая прогрессия с первым членом 2 и разностью 3"
            );
            Console.WriteLine("Арифметическая прогрессия:");
            Console.WriteLine($"Название: {ap.Name}");
            Console.WriteLine($"Описание: {ap.Description}");
            Console.WriteLine($"Дата создания: {ap.CreatedAt}");
            Console.WriteLine($"1-й член: {ap.GetNthTerm(1)}");
            Console.WriteLine($"5-й член: {ap.GetNthTerm(5)}");
            Console.WriteLine($"Убывает: {ap.IsDecreasing()}");
            int nAP = 5;
            double sumAP = ap + nAP;
            Console.WriteLine($"Сумма первых {nAP} членов: {sumAP}");

            Console.WriteLine("\n---------------------------\n");

            GeometricProgression gp = new GeometricProgression(
                firstTerm: 3,
                ratio: 2,
                name: "GP Example",
                description: "Геометрическая прогрессия с первым членом 3 и знаменателем 2"
            );
            Console.WriteLine("Геометрическая прогрессия:");
            Console.WriteLine($"Название: {gp.Name}");
            Console.WriteLine($"Описание: {gp.Description}");
            Console.WriteLine($"Дата создания: {gp.CreatedAt}");
            Console.WriteLine($"1-й член: {gp.GetNthTerm(1)}");
            Console.WriteLine($"4-й член: {gp.GetNthTerm(4)}");
            Console.WriteLine($"Убывает: {gp.IsDecreasing()}");
            int nGP = 4;
            double sumGP = gp * nGP;
            Console.WriteLine($"Сумма первых {nGP} членов: {sumGP}");

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
