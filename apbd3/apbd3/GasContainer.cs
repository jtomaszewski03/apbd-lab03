﻿namespace apbd3;

public class GasContainer : Container, IHazardNotifier
{
    private static int _gasCount;
    public double Pressure;
    public GasContainer(int height, int weight, int depth, int maximumLoadWeight, double pressure) : base(height, weight, depth, maximumLoadWeight)
    {
        SerialNumber += "G-" + _gasCount++;
        Pressure = pressure;
    }

    public override void UnloadContainer()
    {
        LoadWeight *= 0.05;
    }

    public void Notify()
    {
        Console.WriteLine($"Dangerous situation with SN: {SerialNumber}");
    }
    
    public override string ToString()
    {
        return "Gas " + base.ToString();
    }
}