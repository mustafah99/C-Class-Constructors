using System;
using static System.Console;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning about Constructors.");

            // Constructors are special methods that are used to initalize objects.

            /* Benefits of using a constructor: It is called when an object of a 
            class is created. */

            //// Creates an object of the Car class. (This will call upon the constructor).
            //Car FordMustang = new Car();

            //// Now to output the value of the carModel.
            //WriteLine(FordMustang.carModel);

            //// Now to test out our newCar class and constructor.
            //newCar Renault = new newCar("Renault Megane Z");

            //WriteLine(Renault.carModelTwo);

            Car Tesla = new Car("LCT616", "Tesla", "Model S", "coupe", "autopilot");

            WriteLine($"This is a {Tesla.carBrand} {Tesla.carModel} with the license plate {Tesla.regNumber} and is a {Tesla.carType} car type and has {Tesla.carAutopilot}.");
        }

        // Creating a Car class. (See below)
        //class Car
        //{
        //    public string carModel; // Creates a field

        //    // Now we create a class constructor for the Car class.
        //    public Car() // Constructor name must always match the class name.
        //        // Constructors can not have a return type like void or int.
        //        // Constructors are called when objects are created.
        //    {
        //        carModel = "Ford Mustang"; // Set initial value for the car model.
        //    }

        //}

        // Now to create another example of a constructor to really understand them.
        //class newCar
        //{
        //    public string carModelTwo;
        //    // Now to create a constructor with a parameter.
        //    public newCar(string carModelName)
        //    {
        //        carModelTwo = carModelName;
        //    }
        //}

        class Car
        {
            public string regNumber;
            public string carBrand;
            public string carModel;
            public string carType;
            public string carAutopilot;

            // Declaring a class constructor with multiple parameters.
            public Car(string registration, string brand, string model, string type, string autopilot)
            {
                regNumber = registration;
                carBrand = brand;
                carModel = model;
                carType = type;
                carAutopilot = autopilot;
            }
        }

    }
}
