using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    public class KJBibleItem {

        public KJBibleBookDef Book { get; set; }

        public int Chapter { get; set; }

        public int Verse { get; set; }

        public string Scripture { get; set; }

        public override string ToString() {
            return string.Format("{0} \"{1}\"", KJBibleParser.ParserQuotation(Book.Book, Chapter, Verse, 0), Scripture);
        }
    }

    [Flags]
    public enum TestamentType {
        Old,
        New
    }
}
