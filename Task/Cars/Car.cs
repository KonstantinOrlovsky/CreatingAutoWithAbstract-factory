using System;
using Task.Parts;

namespace Task.Cars
{
   abstract class Car
    {
        protected string name;
        protected string body;
        protected Engine Engine;
        protected Paint Paint;
        protected Wheels Wheels;

        public abstract void Description();
        
        public void BodyAssembled()
        {
            Console.WriteLine("Body was Assembled");
        }
        public void EngineInstall()
        {
            Console.WriteLine("Engine was installed");
        }
        public void Painting()
        {
            Console.WriteLine("Car was painted");
        }
        public void WheelesInstall()
        {
            Console.WriteLine("Wheels were installed");
        }


    }
}
