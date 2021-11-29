using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsCS.src.cs.kata.implementation
{
    class EightKataImpl : eightKata
    {

        public int Litres(double time)
        {
            int result;
            result = Convert.ToInt32((time * 0.5) - (time * 0.5) % 1);
            return result;
        }

        public double getVolumeOfCubiod(double length, double width, double height)
        {
            return ((length > 0 && width > 0 && height > 0) ? length * width * height : -1);
        }
    }
}
