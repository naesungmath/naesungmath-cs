using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naesungmath
{
	public class Planarpolygon_Area
	{
		public double equilateral_triangle(double a) //0010
		{
			return ((Math.Pow(a, 2)) * (Math.Sqrt(3)) / 4);
		}

		public double right_triangle_side(double a, double b) //0030
		{
			return a * b / 2;
		}

		public double right_triangle_sin(double b, double c, double angle) //0031
		{
			return b * c * Math.Sin(angle) / 2;
		}

		public double right_triangle_cos(double a, double c, double angle) //0032
		{
			return a * c * Math.Cos(angle) / 2;
		}

		public double triangle(double a, double h) //0060번
		{
			return a * h / 2;
		}
		public double isosceles_triangle(double a, double b) //0050
		{
			return (a / 4) * (Math.Pow((4 * (Math.Pow(a, 2)) - Math.Pow(b, 2))), (1 / 2));
		}

		public double heron(double a, double b, double c) //0070
		{
			var s = ((a + b + c) / 2);
			return Math.Pow((s * (s - a) * (s - b) * (s - c)), (1 / 2));
		}

		public double triangle_angle(double a, double b, double angle) //0080
		{
			return a * b * Math.Sin(angle);
		}

		public double inscribed_circle(double a, double b, double c, double r) //0090
		{
			var ics = (a + b + c) / 2;
			return ics * r;
		}

		public double vector(double a, double angle_a, double b, double angle_b) //0110
        {
			return (Math.Pow(a, 2) * Math.Pow(b, 2)) - (a * b * Math.Sin(angle_a - angle_b)) / 2;
        }

		public double matrix(double x1, double x2, double x3, double y1, double y2, double y3) //0120
        {
			return (((x1 * y2) + (x2 * y3) + (x3 * y1) - (x2 * y1) - (x3 * y2) - (x1 * y3)) / 2);
        }
		public double matrix_four(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4) //0124
        {
			return (((x1 * y2) + (x2 * y3) + (x3 * y4) + (x4 * y1) - (x2 * y1) - (x3 * y2) - (x4 * y3) - (x1 * y4)) / 2);
        }

		public double matrix_five(double x1, double x2, double x3, double x4, double x5, double y1, double y2, double y3, double y4, double y5) //0125
        {
			return (((x1 * y2) + (x2 * y3) + (x3 * y4) + (x4 * y5) + (x5 * y1) - (x2 * y1) - (x3 * y2) - (x4 * y3) - (x5 * y4) - (x1 * y5) / 2));
		}

		public double matrix_six(double x1, double x2, double x3, double x4, double x5, double x6, double y1, double y2, double y3, double y4, double y5, double y6) //0126
        {
			return (((x1 * y2) + (x2 * y3) + (x3 * y4) + (x4 * y5) + (x5 * y6) + (x6 * y1)- (x2 * y1) - (x3 * y2) - (x4 * y3) - (x5 * y4) - (x6 * y5) - (x1 * y6) / 2));
		}

		public double matrix_seven(double x1, double x2, double x3, double x4, double x5, double x6, double x7, double y1, double y2, double y3, double y4, double y5, double y6, double y7) //0127
        {
			return (((x1 * y2) + (x2 * y3) + (x3 * y4) + (x4 * y5) + (x5 * y6) + (x6 * y7) + (x7 * y1) - (x2 * y1) - (x3 * y2) - (x4 * y3) - (x5 * y4) - (x6 * y5) - (x7 * y6) - (x1 * y7) / 2));
		}

		public double square(double a) //0150
        {
			return Math.Pow(a, 2);
        }

		public double rectangle(double a, double b) //0160
        {
			return a * b;
        }

		public double rhombus(double a, double b) //0190
        {
			return a * b / 2;
        }

		public double parallelogram(double a, double h) //0200
        {
			return a * h;
        }

		public double trapezoidal(double a, double b, double h) //0210
        {
			return (a + b) * h / 2;
        }
	}
}
