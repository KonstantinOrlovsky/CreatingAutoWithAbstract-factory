
using Task.Parts;

namespace Task.CarPartsFactory
{
   public abstract class CarPartFactory
    {
       
        public abstract Engine CreateEngine();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();

    }
}
