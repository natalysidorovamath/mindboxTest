

namespace MindBoxLibrary
{
    public class CircleBase : BaseFigure
    {
        private readonly  double _radius;
        public CircleBase(double radius)
        {
            _radius = radius;
        }

        public override double SquareFigure()
        {
            return Math.PI*this._radius*this._radius;
        }
    }
}
