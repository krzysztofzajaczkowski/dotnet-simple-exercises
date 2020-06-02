using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FileAlphanumericCounter
{
    public static class StringExtension
    {
        public static IEnumerable<(char Character, int Count)> GetCharactersCount(this string content)
        {
            return content.GroupBy(c => c)
                .Select(c => (Character: c.Key, Count: c.Count()))
                .OrderByDescending(t => t.Count);
        }
    }
}