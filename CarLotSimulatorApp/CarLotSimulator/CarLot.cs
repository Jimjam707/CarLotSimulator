using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    
    public List<Car> Cars { get; set; } = new List<Car>();

    public void CarList()
    {
        foreach (var car in Cars)
        {
            car.CarTypes(car.Make, car.Model, car.Year);
        }
    }
    
    
    
}