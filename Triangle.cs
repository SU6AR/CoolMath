using System;

namespace CoolMath
{
    public static class Triangle
    {
        public static bool IsRect(double a, double b, double c)
        {
            if ((a <= 0) || (b <= 0) || (b <= 0))
                throw new ArgumentException("Bad arguments");
            if (!((a < (b + c))
                & (b < (a + c))
                & (c < (a + b))))
                throw new ArgumentException("This triangle does not exist");
            else
            {
                var hypotenuse = a;
                if (hypotenuse < b)
                    hypotenuse = b;
                if (hypotenuse < c)
                    hypotenuse = c;
                if ((hypotenuse * hypotenuse) == (a * a + b * b))
                    return true;
                else
                    return false;
            }
        }
    }
}