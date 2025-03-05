namespace ProgressionsDemo;

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