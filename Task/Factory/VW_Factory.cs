using Task.Cars;

namespace Task.Factory
{
   abstract class VW_Factory
    {
        
        public Car GetCar(string type)
        {
            Car car=CreatCar(type);
            car.Description();
            car.BodyAssembled();
            car.EngineInstall();
            car.Painting();
            car.WheelesInstall();


            return car;
        }
        public abstract Car CreatCar(string type);

        
    }
}
