using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveNineElevenFifteen
{
    public class Square : Shape1, Shape2
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            var area = this.Length * this.Width;
            return area;

        }

        public double CalculatePerimeter()
        {
            var TotalLength = this.Length * 2;
            var TotalWidth = this.Width * 2;
            var Perimeter = TotalWidth + TotalLength;
            return Perimeter;

        }
    }
}

