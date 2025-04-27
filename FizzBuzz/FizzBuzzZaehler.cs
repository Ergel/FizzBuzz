using System;

namespace FizzBuzz
{
    public class FizzBuzzZaehler
    {
        public static string FizzBuzz(int zahl)
        {
            if (zahl % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (zahl % 3 == 0)
            {
                return "Fizz";
            }
            else if (zahl % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return zahl.ToString();
            }
        }
    }
}