using apbd3;

CoolingContainer coolingContainer = new CoolingContainer(500, 1500, 300, 20000);
Container liquidContainer = new LiquidContainer(400, 1000, 500, 20000, true);
Container gasContainer = new GasContainer(200, 500, 200, 500, 3.5);
ContainerShip containerShip = new ContainerShip(50, 30, 500);
coolingContainer.LoadContainer(300, "Eggs");
Console.WriteLine(coolingContainer);
coolingContainer.LoadContainer(500, "Frozen pizza");
coolingContainer.UnloadContainer();
coolingContainer.LoadContainer(500, "Butter");
containerShip.AddContainer(coolingContainer);
List<Container> containers = new List<Container>();
containers.Add(liquidContainer);
try
{
    liquidContainer.LoadContainer(19000);
}
catch (OverfillException e)
{
    Console.WriteLine("OverfillException: " + e.Message);
}

try
{
    gasContainer.LoadContainer(550);
}
catch (OverfillException e)
{
    Console.WriteLine("OverfillException: " + e.Message);
}

containers.Add(gasContainer);
containerShip.LoadContainers(containers);
Console.WriteLine(coolingContainer);
Console.WriteLine(liquidContainer);
Console.WriteLine(containerShip);
containerShip.RemoveContainer(coolingContainer);
Console.WriteLine(containerShip);
containerShip.ExchangeContainer("KON-G-0", new CoolingContainer(550, 1500, 500, 25000));
Console.WriteLine(containerShip);
ContainerShip containerShip2 = new ContainerShip(80, 50, 600);
containerShip.TransferContainer("KON-C-1", containerShip2);
Console.WriteLine(containerShip);
Console.WriteLine(containerShip2);