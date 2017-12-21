namespace ExamplePlayground
{
    public static class ArrayManipulation
    {
        public static int[] StortArrayLowHigh(int[] input)
        {
            if (input == null) { return null; }
            if (input.Length == 1) { return input; }

            for (var index = 0; index < input.Length; index++)
            {
                for (var secondaryIndex = index + 1; secondaryIndex < input.Length; secondaryIndex++)
                {
                    if (input[secondaryIndex] < input[index])
                    {
                        var holder = input[index];
                        input[index] = input[secondaryIndex];
                        input[secondaryIndex] = holder;
                    }
                }
            }

            return input;
        }
    }
}
