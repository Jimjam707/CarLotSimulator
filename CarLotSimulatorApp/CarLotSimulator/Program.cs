﻿using System;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System.ComponentModel;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            var carsInLot = new CarLot();
            
            var fordMustang = new Car("Ford", "Mustang", 1964, "Yes");
            carsInLot.Cars.Add(fordMustang);
            
            var toyotaCorolla = new Car();
            toyotaCorolla.Make = "Toyota";
            toyotaCorolla.Model = "Camry";
            toyotaCorolla.Year = 2001;
            toyotaCorolla.IsDriveable = "Yes";
            toyotaCorolla.MakeEngineNoise("Vroom!");
            toyotaCorolla.MakeHonkNoise("Beep!");
            carsInLot.Cars.Add(toyotaCorolla);
            
            var subaruWrx = new Car() { Make = "Subaru", Model = "WRX", Year = 2022, IsDriveable = "No"};
            carsInLot.Cars.Add(subaruWrx);
            
            carsInLot.CarList();
            

        }
        
    }
}
