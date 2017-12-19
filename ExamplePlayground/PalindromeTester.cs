namespace ExamplePlayground
{
    public static class PalindromeTester
    {
        public static bool Check(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            if(input.Length < 2)
            {
                return true;
            }

            var inputLower = input.ToLower();

            for(var index = 0; index < input.Length; index++)
            {
                var endMarker = (inputLower.Length-1) - index;

                if(index == endMarker) { return true; }

                if(inputLower[index] != inputLower[endMarker])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
