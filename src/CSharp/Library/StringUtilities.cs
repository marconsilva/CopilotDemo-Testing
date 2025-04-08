using System;

namespace Library
{
    public class StringUtilities
    {
        public string Concatenate(string str1, string str2)
        {
            return str1 + str2;
        }

        public string[] Split(string input, char delimiter)
        {
            return input.Split(delimiter);
        }

        public bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public string ToUpperCase(string input)
        {
            return input?.ToUpper();
        }

        public string ToLowerCase(string input)
        {
            return input?.ToLower();
        }
    }
}