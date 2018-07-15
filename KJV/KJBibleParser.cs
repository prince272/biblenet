using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    internal class KJBibleParser {
        public static string ParserQuotation(string bookName, int chapterNum, int verseFromNum, int verseToNum) {
            string parser = string.Empty;
            parser += string.Format("{0} {1}:{2}", bookName, chapterNum, verseFromNum, verseToNum);
            if (verseToNum > 0)
                parser += string.Format("-{0}", verseToNum);
            return parser;
        }
    }
}
