using System.Text;

namespace ExamplePlayground
{
    public static class StringManipulation
    {
        public static string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                return input;
            }

            var stringbuilder = new StringBuilder();

            for(var index = input.Length-1; index >-1; index--)
            {
                stringbuilder.Append(input[index]);
            }

            return stringbuilder.ToString();
        }
    }
}
