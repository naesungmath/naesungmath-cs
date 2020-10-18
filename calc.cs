using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naesungmathcs
{
    public class calc
    {
        public double plus(double a, double b)
        {
            return a + b;
        }

        public double minus(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double divide(double a, double b)
        {
            return a / b;
        }

        public double caret(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }

        public double pow(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }

        public double sqrt(double a)
        {
            return (double)Math.Sqrt(a);
        }

        public double random()
        {
            Random r = new Random();
            return r.Next();
        }

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

        public double radian(double a)
        {
            return 2 * Math.PI * a;
        }
    }
}
