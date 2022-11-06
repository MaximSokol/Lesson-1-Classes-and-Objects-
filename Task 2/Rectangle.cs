using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1__Classes_and_Objects_.Task_2
{
    class Rectangle
    {
        double firstSide;
        double secondSide;
        //-------------------------------------------

        public Rectangle(double fSide, double sSide)
        {
            this.firstSide = fSide;
            this.secondSide = sSide;
        }
        //-------------------------------------------------------

        public double FirstSide { get { return this.firstSide; } }
        public double SecondSide { get { return this.secondSide; } }
        //-------------------------------------------------------------

        public string AreaOfRectangle()
        {
            if (this.FirstSide != 0.0 && this.SecondSide != 0.0)
            {
                return $"Area:\t{FirstSide * SecondSide}"; 
            }
            else
                return $"The values are empty!";
        }
        //-------------------------------------------------------------

        public string PerimeterOfRectangle()
        {
            if (this.FirstSide != 0.0 && this.SecondSide != 0.0)
            {
                return $"Perimeter:\t{(FirstSide + SecondSide) * 2}";
            }
            else
                return $"The values are empty!";
        }
        //-------------------------------------------------------------
    }
}
