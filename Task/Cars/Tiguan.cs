using System;
using Task.CarPartsFactory;

namespace Task.Cars
{
    class Tiguan : Car
    {
        private CarPartFactory _factory;

        public Tiguan(CarPartFactory factory)
        {
            name = "Tiguan";
            body = "Crossover";
            _factory = factory;
        }

        public override void Description()
        {
            Console.WriteLine($"Description: {name}");
            Console.WriteLine($"Body: {body}");
            _factory.CreateEngine();
            _factory.CreatePaint();
            _factory.CreateWheels();

        }
    }
} 
