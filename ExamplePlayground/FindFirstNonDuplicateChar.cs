namespace ExamplePlayground
{
    public static class FindFirstNonDuplicateChar
    {
        public static string Find(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2) { return input; }
            if (input.Length == 2 && (input[0] == input[1]))
            {
                return string.Empty;
            }

            for (var index = 0; index < input.Length; index++)
            {
                var rest = input.Remove((index), 1);
                if (rest.IndexOf(input[index]) == -1)
                {
                    return input[index].ToString();
                }
            }

            return string.Empty;
        }
    }
}
