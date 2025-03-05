namespace ProgressionsDemo;

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
