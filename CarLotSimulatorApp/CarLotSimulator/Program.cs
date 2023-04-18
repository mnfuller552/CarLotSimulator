using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();

            
            var carOne = new Car();
            carOne.Year = 2013;
            carOne.Make = "Ford";
            carOne.Model = "Focus";
            carOne.IsDriveable = true;
            carOne.HonkNoise = "beep";
            carOne.EngineNoise = "vroom";

            lot.Cars.Add(carOne);

            Console.WriteLine(Car.AmountOfCarsCreated);

            var carTwo = new Car();

            carTwo.Year = 2019;
            carTwo.Make = "Tesla";
            carTwo.Model = "Model S";
            carTwo.IsDriveable = true;
            carTwo.HonkNoise = "brmmp";
            carTwo.EngineNoise = "silent";

            lot.Cars.Add(carTwo);

            Console.WriteLine(Car.AmountOfCarsCreated);

            var carThree = new Car(2014, "Jeep", "Wrangler", "loud", "honk", true);

            lot.Cars.Add(carThree);

            Console.WriteLine(Car.AmountOfCarsCreated);

            carOne.MakeEngineNoise(carOne.EngineNoise);
            carOne.MakeHonkNoise(carOne.HonkNoise);

            carTwo.MakeEngineNoise(carTwo.EngineNoise);
            carTwo.MakeHonkNoise(carTwo.HonkNoise);

            carThree.MakeEngineNoise(carThree.EngineNoise);
            carThree.MakeHonkNoise(carThree.HonkNoise);


            foreach(var Car in lot.Cars)
            {

                Console.WriteLine($" Year:{Car.Year} Make:{Car.Make} Model:{Car.Model}");

            }








            
            

            
          

        }
    }
}
