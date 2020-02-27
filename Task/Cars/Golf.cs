using System;
using Task.CarPartsFactory;

namespace Task.Cars
{
    class Golf:Car
    {
        private CarPartFactory _carPartFactory;
        public Golf(CarPartFactory factory)
        {
            name = "Golf";
            body = "Hatchback";
            _carPartFactory = factory;
        }

        public override void Description()
        {
            Console.WriteLine($"Description: {name}");
            Console.WriteLine($"Body: {body}");

           Engine = _carPartFactory.CreateEngine();
           Paint= _carPartFactory.CreatePaint();
           Wheels= _carPartFactory.CreateWheels();
           
        }
    }
}
