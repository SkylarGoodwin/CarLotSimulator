using System;

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
            var Car1 = new Car();
            Car1.Make = "Tesla";
            Car1.Model = "Y";
            Car1.Year = 2023;
            Car1.EngineNoise = "Electric";
            Car1.HonkNoise = "Honk 1";
            Car1.IsDriveable = false;

            var Car2 = new Car();
            Car2.Make = "Toyota";
            Car2.Model = "RAV4";
            Car2.Year = 1995;
            Car2.EngineNoise = "Vroom";
            Car2.HonkNoise = "Honk 2";
            Car2.IsDriveable = true;

            var Car3 = new Car();
            Car3.Make = "Honda";
            Car3.Model = "CR-V";
            Car3.Year = 2007;
            Car3.EngineNoise = "put-put";
            Car3.HonkNoise = "Honk 3";
            Car3.IsDriveable = true;
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
