namespace apbd3;

public class GasContainer : Container
{
    private static int _gasCount;
    public GasContainer(int height, int weight, int depth, int maximumLoadWeight) : base(height, weight, depth, maximumLoadWeight)
    {
        SerialNumber += "G-" + _gasCount++;
    }
}