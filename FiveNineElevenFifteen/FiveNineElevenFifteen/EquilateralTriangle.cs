using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveNineElevenFifteen
{
   
    class EquilateralTriangle : AbstractTriangle
    {

        public double side { get; set; }

        public double height { get; set; }

        public override double CalculateArea()
        {
            var area = .5 * (this.side * this.height);
            return area;
        }

        public override double CalculatePerimeter()
        {
            var perimeter = this.side * 3;
            return perimeter;
        }
    }
}
