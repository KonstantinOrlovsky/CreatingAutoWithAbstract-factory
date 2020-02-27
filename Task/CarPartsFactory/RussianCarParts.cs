
using Task.Parts;

namespace Task.CarPartsFactory
{
    class RussianCarParts : CarPartFactory
    {
        public override Engine CreateEngine()
        {
            return new GasolineEngine();
        }

        public override Paint CreatePaint()
        {
            return new BlackPaint();
        }

        public override Wheels CreateWheels()
        {
            return new SmallWheels();
        }
    }
}
