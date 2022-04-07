using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLibrary
{
    public interface ITriangle
    {
        double Perimeter(double[] arrSides);
        bool CheckTypeFigure();
        bool CheckExistinigTriangle(double[] arrSides);
    }
}
