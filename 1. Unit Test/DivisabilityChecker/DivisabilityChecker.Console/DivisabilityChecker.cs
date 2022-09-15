// See https://aka.ms/new-console-template for more information

namespace DivisabilityChecker.Console
{
    public class DivisabilityChecker
    {
        public string GetDivisableText(string? input)
        {
            int inputInteger;
            if (int.TryParse(input, out inputInteger))
            {
                if (inputInteger % 3 == 0 && inputInteger % 5 == 0)
                    return "FizzBuzz";
                if (inputInteger % 3 == 0)
                    return "Fizz";
                if (inputInteger % 5 == 0)
                    return "Buzz";
                return inputInteger.ToString();
            }
            else
            {
                return "Please enter valid integer next time.";
            }
        }
    }
}