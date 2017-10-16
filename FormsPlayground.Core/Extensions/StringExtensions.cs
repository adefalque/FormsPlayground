using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPlayground.Core.Extensions
{
    public static class StringExtensions
    {
        private static readonly char[] Separator = {' '};

        public static string GetInitials(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            var initialCharacters = s.Split(Separator, StringSplitOptions.RemoveEmptyEntries)
                .Take(3)
                .Select(x => x.Cast<char>().FirstOrDefault(char.IsLetterOrDigit))
                .Where(c => c != default(char))
                .Select(char.ToUpper)
                .ToArray();

            return new string(initialCharacters);
        }
    }
}
