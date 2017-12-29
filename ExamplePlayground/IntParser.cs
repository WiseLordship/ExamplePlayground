using System;
using System.Text.RegularExpressions;

namespace ExamplePlayground
{
    public class IntParser
    {
        public static int Parse(string input)
        {
            if (string.IsNullOrEmpty(input)) { throw new Exception("Not valid input"); }

            var isNegative = false;
            if (input[0] == '-')
            {
                isNegative = true;
                input = input.Substring(1);
            }

            if (!Regex.IsMatch(input, "^[0-9]*$")){ throw new Exception("Not valid input"); }

            var results = 0;

            if (input.Length == 1)
            {
                results = (int)char.GetNumericValue(input[0]);
            }
            else
            {
                for (var index = (isNegative ? 1 : 0); index < input.Length; index++)
                {
                    var addedValue = (int)Math.Pow(10, (input.Length - 1 - index)) * (int)char.GetNumericValue(input[index]);
                    results += addedValue;
                }
            }

            return isNegative ? -results : results;
        }
    }
}
