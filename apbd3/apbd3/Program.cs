// See https://aka.ms/new-console-template for more information

using apbd3;

Container coolingContainer = new CoolingContainer(500,1500,300,20000, "Fish");
Container liquidContainer = new LiquidContainer(400, 1000, 500, 20000, true);
Container gasContainer = new GasContainer(200, 500, 200, 500, 3.5);
ContainerShip containerShip = new ContainerShip(50, 30, 500);
containerShip.LoadContainer(coolingContainer);
List<Container> containers = new List<Container>();
containers.Add(liquidContainer);
containers.Add(gasContainer);
containerShip.LoadContainers(containers);
Console.WriteLine(coolingContainer);
Console.WriteLine(liquidContainer);
Console.WriteLine(containerShip);
containerShip.RemoveContainer(coolingContainer);
Console.WriteLine(containerShip);
containerShip.ExchangeContainer("KON-G-0", new CoolingContainer(550,1500,500,25000, "Meat"));
Console.WriteLine(containerShip);
ContainerShip containerShip2 = new ContainerShip(80, 50, 600);
containerShip.TransferContainer("KON-C-1", containerShip2);
Console.WriteLine(containerShip);
Console.WriteLine(containerShip2);