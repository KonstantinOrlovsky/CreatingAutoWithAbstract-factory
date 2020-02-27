using System;
using Task.CarPartsFactory;

namespace Task.Cars
{
    class Passat:Car
    {
        private CarPartFactory _factory;
        public Passat(CarPartFactory factory)
        {
            _factory = factory;
            name = "Passat";
            body = "Sedan";
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
