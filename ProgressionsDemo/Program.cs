using System;

namespace ProgressionsDemo
{
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
