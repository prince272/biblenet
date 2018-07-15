using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    internal class KJBibleHelper {

        static Stream GetBibleDataStream() {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream("BibleNet.Resources.kjvdat.txt");
        }

        public static IEnumerable<KeyValuePair<string, string>> GetBibleDataInfo() {
            Stream stream = GetBibleDataStream();
            using (var reader = new StreamReader(stream)) {
                string line = null;
                while ((line = reader.ReadLine()) != null) {
                    string[] split = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string key = string.Format("{0}|{1}|{2}", split[0], split[1], split[2]);
                    string value = split[3].Trim('~', ' ');
                    yield return new KeyValuePair<string, string>(key, value);
                }
            }
        }

        public static Dictionary<string, KJBibleBookDef> GenerateBookDefs(string bookName, int chapterNum, int verseFromNum, int verseToNum) {
            var defs = new Dictionary<string, KJBibleBookDef>();
            int count = CalTotalBibleNums(chapterNum, verseFromNum, verseToNum);
            KJBibleBookDef? def = KJBibleBookDef.Find(bookName);
            for (int i = 0; i < count; i++) {
                if (def.HasValue) {
                    var key = string.Format("{0}|{1}|{2}", def.Value.Abbreviation2, chapterNum, verseFromNum + i);
                    defs.Add(key, def.Value);
                }
            }
            return defs;
        }

        static int CalTotalBibleNums(int chapterNum, int verseFromNum, int verseToNum) {
            if (chapterNum < 1 && chapterNum > 150)
                return -1;
            else if (verseFromNum < 1 || verseFromNum > 176)
                return -1;
            else if (verseToNum != -1 && (verseToNum < 1 || verseToNum > 176))
                return -1;
            if (verseToNum == -1)
                verseToNum = 176;
            return (verseToNum - verseFromNum) + 1;
        }
    }
}