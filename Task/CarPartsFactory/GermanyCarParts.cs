
using Task.Parts;

namespace Task.CarPartsFactory
{
    class GermanyCarParts:CarPartFactory
    {
        public override Engine CreateEngine()
        {
            return new DieselEngine();
        }

        public override Paint CreatePaint()
        {
            return new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new LargeWheels();
        }
    }
}
