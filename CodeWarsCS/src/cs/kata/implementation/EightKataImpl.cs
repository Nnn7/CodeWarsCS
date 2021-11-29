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

        public double GetVolumeOfCubiod(double length, double width, double height)
        {
            return ((length > 0 && width > 0 && height > 0) ? length * width * height : -1);
        }

        public string ReversedStrings(string str)
        {          
            List<string> result0 = new List<string>();
            for (var i=0; i<str.Length; i++)
            {
                result0.Add(str[i].ToString());            
            }
            result0.Reverse();
            string result = string.Join("", result0);
            return result;
            //return new string(str.ToArray().Reverse().ToArray());
        }

        public int GetRealFloor(int n)
        {
            int result = 0;
            if (n < 0)
            {
                return n;
            }

            if (n < 13 && n > 0)
            {
                return n - 1;
            }

            if (n > 12)
            {
                return n - 2;
            }
            return result;
        }

        //-- ASCII Total
        public int UniTotal(string str)
        {
            if (str == "") return 0;
            int sum = 0;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                sum += asciiBytes[i];
            }
            Console.WriteLine(str);
            return sum;
        }

        public string Correct(string text)
        {
            text = text.Replace("5", "S");
            text = text.Replace("0", "O");
            text = text.Replace("1", "I");
            return text;
        }
    }
}
