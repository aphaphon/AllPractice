using System;

namespace demoapi
{
    public class FitBuzzLogic
    {
        // 3     >> Fit
        // 5     >> Buzz
        // 3 & 5 >> FitBuzz
        public string Calculate(int number)
        {
            if (number <= 0)return "Error";

            if (number % 5 == 0 && number % 3 == 0)
            {
                return "FitBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fit";

            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

    }
}