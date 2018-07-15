using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.Extensions {
    internal static class StringExtension {
        public static string RemoveSpaces(this string mainValue) {
            while (mainValue.Contains(" "))
                mainValue = mainValue.Replace(" ", string.Empty);
            return mainValue;
        }

        public static string RemoveLastEnds(this string mainValue, string[] lastEnds, StringComparison comparison) {
            foreach (var l in lastEnds) {
                if (mainValue.EndsWith(l, comparison))
                    mainValue = mainValue.Substring(0, mainValue.Length - l.Length);
            }
            return mainValue.Trim();
        }

        public static bool StringContains(this string source, string toCheck, StringComparison comp) {
            if (string.IsNullOrEmpty(toCheck) || string.IsNullOrEmpty(source))
                return true;
            bool sucess = source.IndexOf(toCheck, comp) >= 0;
            return sucess;
        }
    }
}