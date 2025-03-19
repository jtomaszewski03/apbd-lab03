namespace apbd3;

public class Container
{
    public int? LoadWeight { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string SerialNumber { get; set; }
    public int MaximumLoadWeight { get; set; }

    public Container(int height, int weight, int depth, int maximumLoadWeight)
    {
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON-";
        MaximumLoadWeight = maximumLoadWeight;
    }

    public void UnloadContainer()
    {
        LoadWeight = 0;
    }

    public virtual void LoadContainer(int weight)
    {
        if (weight > MaximumLoadWeight)
            throw new OverfillException("Weight cannot be greater than maximum load weight");
    }
}