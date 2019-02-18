using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public static class StringOperations
    {
        public static string Reverse(string text)
        {
            return new string(text.Reverse().ToArray());
        }

        public static string Duplicate(string text)
        {
            return text + text;
        }

        public static string Concat(string text1, string text2)
        {
            return text1 + text2;
        }

        public static string Join(IEnumerable<string> strings)
        {
            return string.Join(" ", strings);
        }
    }
}
