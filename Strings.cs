namespace Strings
{
    public class Strings
    {
        string greeting = "Hello";

        int GetLength(string s)
        {
            return s.Length;
        }

        string ToUpperCase(string s)
        {
            return s.ToUpper();
        }

        string ToLowerCase(string s)
        {
            return s.ToLower();
        }

        string Concatenate(string s1, string s2)
        {
            return s1 + s2;
        }

        string Interpolation(string s, int number)
        {
            return $"{s} {number}";
        }

        char CharAt(string s, byte position)
        {
            return s[position];
        }

        int IndexOf(string s, string substring)
        {
            return s.IndexOf(substring);
        }
    }
}
