namespace apbd3;

public class ContainerShip(int speed, int maxContainerNum, int maxWeight)
{
    private List<Container> _containers = new();
    private int _speed = speed;
    private int _maxContainerNum = maxContainerNum;
    private int _maxWeight = maxWeight;

    public void AddContainer(Container container)
    {
        _containers.Add(container);
    }

    public void LoadContainers(List<Container> containers)
    {
        _containers.AddRange(containers);
    }

    public void RemoveContainer(Container container)
    {
        _containers.Remove(container);
    }

    public void ExchangeContainer(string serialNumber, Container container)
    {
        _containers.Add(container);
        _containers.RemoveAll(c => c.SerialNumber == serialNumber);
    }

    public void TransferContainer(string serialNumber, ContainerShip ship)
    {
        if (_containers.Any(c => c.SerialNumber == serialNumber))
        {
            var container = _containers.Find(c => c.SerialNumber == serialNumber);
            if (container != null)
            {
                ship.AddContainer(container);
                _containers.Remove(container);
            }
            else
            {
                Console.WriteLine("Unable to find container " + serialNumber);
            }
        }
        else Console.WriteLine($"Container: {serialNumber} not found");
    }

    public override string ToString()
    {
        return $"ContainerShip - [Speed: {_speed}, MaxContainerNum: {_maxContainerNum}, MaxWeight: {_maxWeight}]" +
               " Loaded with containers: " +
               string.Join(", ", _containers.Select(c => c.SerialNumber));
    }
}