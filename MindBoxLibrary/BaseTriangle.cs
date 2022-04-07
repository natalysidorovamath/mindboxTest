
namespace MindBoxLibrary
{

   public  class BaseTriangle: BaseFigure, ITriangle
    {
        private double[] _strEnter;
        public BaseTriangle(string?[] str)
        {
            this._strEnter = ConvertStringArrToDoubleArr(str);
        }
    
        //if true then it is a right triangle
        public bool CheckTypeFigure( )
        {
            bool btCheck = false;
            if (!CheckExistinigTriangle(this._strEnter)) {
                btCheck = true;
                Console.WriteLine("Треугольника с такими длинами сторон не существует; Задайте иные стороны треугольника");
            }
            if (CheckTheoremPifagora(this._strEnter[0], this._strEnter[1], this._strEnter[2]))
                Console.WriteLine("Заданный треугольник является прямоугольным");
            return btCheck;
        }

        private bool CheckTheoremPifagora(double a, double b, double c)
        {
            return (a * a == b * b + c * c )|| (b * b == a * a + c * c) || (c * c == a * a + b * b);
        }

        public virtual double Perimeter(double[] arrSides)
        {
            return arrSides.Sum() * 0.5;
        }

        public bool CheckExistinigTriangle(double[] arrSides)
        {
            bool bFirst = arrSides[0] + arrSides[1] > arrSides[2];
            bool bSecond = arrSides[2] + arrSides[0] > arrSides[1];
            bool bThird = arrSides[2] + arrSides[1] > arrSides[0];
            if (!bFirst|| !bSecond||!bThird) return false;
            return true;
        }

        public override double  SquareFigure()
        {
            if (CheckTypeFigure()) { return -1.0; }
            double perimetr=this.Perimeter(this._strEnter);
            return Math.Sqrt( perimetr * (perimetr - this._strEnter[0]) * (perimetr - this._strEnter[1]) * (perimetr - this._strEnter[2]));
         }

        private double[]  ConvertStringArrToDoubleArr(string?[] arrString)
        {
            double[] arrDouble = new double[arrString.Length];
            for (int i = 0; i < arrString.Length; i++)
            {
                arrDouble[i] =(arrString[i] is null? 0.0: Convert.ToDouble(arrString[i]));
            }
            return arrDouble;
        }

        
    }
}
