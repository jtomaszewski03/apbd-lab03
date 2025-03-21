namespace apbd3;

public class Container
{
    public double LoadWeight { get; set; }
    public int Height { get; init; }
    public int Weight { get; init; }
    public int Depth { get; init; }
    public string SerialNumber { get; init; }
    public int MaximumLoadWeight { get; init; }

    public Container(int height, int weight, int depth, int maximumLoadWeight)
    {
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON-";
        MaximumLoadWeight = maximumLoadWeight;
    }

    public virtual void UnloadContainer()
    {
        LoadWeight = 0;
    }

    public virtual void LoadContainer(int weight)
    {
        if (weight > MaximumLoadWeight)
            throw new OverfillException("Weight cannot be greater than maximum load weight");
        LoadWeight = weight;
    }

    public override string ToString()
    {
        return
            $"Container: {SerialNumber}, {nameof(Height)}: {Height}, {nameof(Weight)}: {Weight}, {nameof(Depth)}: {Depth}, {nameof(LoadWeight)}: {LoadWeight}, {nameof(MaximumLoadWeight)}: {MaximumLoadWeight}";
    }
}