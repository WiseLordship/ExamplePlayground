using System.Text;

namespace ExamplePlayground
{
    public class RemoveDuplicateChars
    {
        public static string Remove(string input)
        {
            if (string.IsNullOrEmpty(input)) { return input; }
            if (input.Length == 1) { return input; }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(input[0]);

            for (var index = 1; index < input.Length; index++)
            {
                if (input[index] != input[index - 1])
                {
                    stringBuilder.Append(input[index]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
