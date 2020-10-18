using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naesungmathcs
{
    public class calc
    {
        /// <summary>
        /// A plus B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double plus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// A minus B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double minus(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// A multiply B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double multiply(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// A divide B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double divide(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// A caret B
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double caret(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }
        /// <summary>
        /// A to the B power
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double pow(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }
        /// <summary>
        /// Square root of A
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double sqrt(double a)
        {
            return (double)Math.Sqrt(a);
        }

        public double random()
        {
            Random r = new Random();
            return r.Next();
        }
        /// <summary>
        /// Determine if this number is prime. 
        /// If the number is prime, return true.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool prime(double a)
        {
            if (a <= 1)
                return false;
            for (double i = 2; i < Math.Sqrt(a); a++)
            {
                if ((a %= i) == 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Convert degree to radian.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public double radian(double a)
        {
            return 2 * Math.PI * a;
        }
    }
}
