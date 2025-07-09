using System;

namespace CarLotSimulator;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public string IsDriveable { get; set; }

    public void MakeEngineNoise(string noise)
    {
        EngineNoise = noise;
    }

    public void MakeHonkNoise(string honk)
    {
        HonkNoise = honk;   
    }

    public Car()
    {
        
    }

    public Car(string make, string model, int year, string driveable)
    {
        Make = make;
        Model = model;
        Year = year;
        IsDriveable = driveable;
    }

    public void CarTypes(string make, string model, int year)
    {
        Console.WriteLine($"The car is a {make} {model} {year}");
    }
}