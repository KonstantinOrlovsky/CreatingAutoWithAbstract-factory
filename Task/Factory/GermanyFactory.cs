using Task.Cars;
using Task.CarPartsFactory;

namespace Task.Factory
{
    class GermanyFactory : VW_Factory
    {
        public override Car CreatCar(string type)
        {
            CarPartFactory factory = new GermanyCarParts();
            
            if (type == "golf")
            {
                return new Golf(factory);
            }
            else if (type == "passat")
            {
                return new Passat(factory);
            }
            else if (type == "tiguan")
            {
                return new Tiguan(factory);
            }
            
            return null;
        }

        
    }
}
