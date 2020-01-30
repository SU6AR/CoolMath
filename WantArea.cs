using System;

namespace CoolMath
{
    public static class WantArea
    {
        public static double GetArea(double a, double b, double c)//для треугольника
        {
            if ((a <= 0) || (b <= 0) || (b <= 0))
                throw new ArgumentException("Bad arguments");
            if (!((a < (b + c))
                & (b < (a + c))
                & (c < (a + b))))
                throw new ArgumentException("This triangle does not exist");
            else
            {
                var halfperim = (a + b + c) / 2;
                return Math.Sqrt(halfperim * (halfperim - a) * (halfperim - b) * (halfperim - c));
            }
        }

        public static double GetArea(int r)//для круга
        {
            if (r <= 0)
                throw new ArgumentException("Bad arguments");
            return Math.PI * r * r;
        }
    }
}