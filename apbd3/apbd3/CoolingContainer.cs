namespace apbd3;

public class CoolingContainer : Container
{
    private static int _coolingCount;
    public CoolingContainer(int height, int weight, int depth, int maximumLoadWeight) : base(height, weight, depth, maximumLoadWeight)
    {
        SerialNumber += "C-" + _coolingCount++;
    }
}