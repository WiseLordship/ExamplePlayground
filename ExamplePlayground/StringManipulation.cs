﻿using System.Text;

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

        public static string RemoveDuplicateChars(string input)
        {
            if(string.IsNullOrEmpty(input)) { return input; }
            if(input.Length == 1) { return input; }

            var stringBuilder = new StringBuilder();
            stringBuilder.Append(input[0]);

            for (var index = 1; index < input.Length; index++)
            {
                if(input[index] != input[index - 1])
                {
                    stringBuilder.Append(input[index]);
                }
            }
            return stringBuilder.ToString();
        }
    }
}
