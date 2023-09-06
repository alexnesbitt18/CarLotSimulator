using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car -- Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -- Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() -- Done
            //The methods should take one string parameter: the respective noise property -- Done


            //Now that the Car class is created we can instanciate 3 new cars -- Done
            //Set the properties for each of the cars -- Done
            //Call each of the methods for each car -- Done

            //Instanciate Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();

            var prius = new Car();
            prius.Year = 2010;
            prius.Make = "Toyota";
            prius.Model = "Prius";
            prius.EngineNoise = "Whhhhrrrrrr";
            prius.HonkNoise = "beep beep";
            prius.IsDriveable = true;
            
            lot.Cars.Add(prius);

            var corolla = new Car();
            corolla.Year = 2017;
            corolla.Make = "Toyota";
            corolla.Model = "Corolla";
            corolla.EngineNoise = "Vroooooom";
            corolla.HonkNoise = "Boop";
            corolla.IsDriveable = true;

            lot.Cars.Add(corolla);

            var alexsCar = new Car();
            alexsCar.Year = 1945;
            alexsCar.Make = "Ford";
            alexsCar.Model = "F150";
            alexsCar.EngineNoise = "ERRRRRRRRRR";
            alexsCar.HonkNoise = "Aruuuuggga";
            alexsCar.IsDriveable = false;

            lot.Cars.Add(alexsCar);

            Console.WriteLine($"This is the total amount of cars in the parking lot: {CarLot.numberofCars}.");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}, Engine Noise: {car.EngineNoise}, Honk Noise: {car.HonkNoise}, Is Drivable: {car.IsDriveable}.");
            }


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car -- Redo

            //*************BONUS X 2*************//

            //Create a CarLot class -- Done
            //It should have at least one property: a List of cars -- Done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
