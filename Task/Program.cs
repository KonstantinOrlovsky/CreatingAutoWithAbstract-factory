using System;
using Task.Cars;
using Task.Factory;
using Task.Parts;
using Task.CarPartsFactory;




namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            VW_Factory russiaFactory = new RussiaFactory();
            VW_Factory germanyFactory = new GermanyFactory();


            russiaFactory.GetCar("golf");
            Console.WriteLine();
            russiaFactory.GetCar("passat");
            Console.WriteLine();
            russiaFactory.GetCar("tiguan");
            Console.WriteLine("_____________________________________");
            germanyFactory.GetCar("golf");
            Console.WriteLine();
            germanyFactory.GetCar("passat");
            Console.WriteLine();
            germanyFactory.GetCar("tiguan");







            Console.Read();
        }
        
    }
}
