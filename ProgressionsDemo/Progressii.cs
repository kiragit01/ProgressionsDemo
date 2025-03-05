namespace ProgressionsDemo;

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