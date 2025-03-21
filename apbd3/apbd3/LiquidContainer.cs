namespace apbd3;

public class LiquidContainer : Container, IHazardNotifier
{
    private static int _liquidCount;
    public bool IsDangerous { get; set; }

    public LiquidContainer(int height, int weight, int depth, int maximumLoadWeight, bool isDangerous) : base(height,
        weight, depth,
        maximumLoadWeight)
    {
        SerialNumber += "L-" + _liquidCount++;
        IsDangerous = isDangerous;
    }

    public void Notify()
    {
        Console.WriteLine($"Dangerous operation attempt with SN: {SerialNumber}");
    }

    public override void LoadContainer(int weight)
    {
        if (IsDangerous)
        {
            if (weight > MaximumLoadWeight / 2)
            {
                Notify();
                throw new OverfillException("Weight too high for dangerous goods");
            }

            base.LoadContainer(weight);
        }
        else
        {
            if (weight > MaximumLoadWeight * 0.9)
            {
                Notify();
                throw new OverfillException("Weight too high for liquid container");
            }

            base.LoadContainer(weight);
        }
    }
    
    public override string ToString()
    {
        return "Liquid " + base.ToString();
    }
}