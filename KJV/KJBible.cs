using BibleNet.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    public class KJBible {
        private const string pattern = @"(?<Book>((\b([1-3]\s*)?([a-z]+((\s+[a-z]+){1,3})?)\b\.?)|(\b([1-3]\s*)?[a-z]{3,6}\b\.?)|(\b[a-z]{2,3}[1-3]?\b\.?)))(?<Chapter>(\s+\d{1,3}))?((\s*(verses|verse|vs|\:)\s*)|\s*)(?<Verse>(\d{1,3}))?(((\s*(to|\-)\s*)|\s*)(?<To>(\d{1,3})))?";
        public KJBible() {
        }

        public KJBibleCollection GetQuotations(string bookName, int chapterNum, int verseFromNum, int verseToNum) {
            var defs = KJBibleHelper.GenerateBookDefs(bookName, chapterNum, verseFromNum, verseToNum);
            var col = new KJBibleCollection();
            foreach (var data in KJBibleHelper.GetBibleDataInfo()) {
                foreach (var def in defs) {
                    if (def.Key == data.Key) {
                        var item = CreateBibleItem(def.Value, data);
                        col.Add(item);
                    }
                }
            }
            return col;
        }

        public KJBibleCollection GetQuotations(string expression, bool includeLimit = false) {
            var match = Regex.Match(expression, pattern, RegexOptions.IgnoreCase);
            if (match.Success) {
                string book = GetBookName(match);
                int chapter = GetChapterNum(match);
                int verseFrom = GetVerseFromNum(match);
                int verseTo = GetVerseToNum(match, verseFrom, includeLimit);
                return GetQuotations(book, chapter, verseFrom, verseTo);
            }
            throw new ArgumentException("The expression is invalid.", "expression");
        }

        int GetVerseToNum(Match match, int verseFrom, bool includeLimit) {
            var verseTo = match.Groups["To"].Value.Trim();
            return !string.IsNullOrEmpty(verseTo) ? int.Parse(verseTo) : (includeLimit ? verseFrom : -1);
        }

        string GetBookName(Match match) {
            var book = match.Groups["Book"].Value.Trim(' ', '.');
            book = book.RemoveLastEnds(new string[] { "chapters", "chapter", "ch", "chs" }, StringComparison.OrdinalIgnoreCase);
            return book;
        }

        int GetChapterNum(Match match) {
            var chapter = match.Groups["Chapter"].Value.Trim();
            return !string.IsNullOrEmpty(chapter) ? int.Parse(chapter) : 1;
        }
        
        int GetVerseFromNum(Match match) {
            var verseFrom = match.Groups["Verse"].Value.Trim();
            return !string.IsNullOrEmpty(verseFrom) ? int.Parse(verseFrom) : 1;
        }

        public KJBibleCollection GetVerses(string words, TestamentType testament, int limit = 30) {
            var col = new KJBibleCollection();
            string[] split = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            string sentence = string.Join(" ", split).Trim();
            if (string.IsNullOrWhiteSpace(sentence)) return col;
            foreach (var data in KJBibleHelper.GetBibleDataInfo()) {
                if (split.All(i => data.Value.StringContains(i, StringComparison.OrdinalIgnoreCase))) {
                    var item = CreateBibleItem(data);
                    if (testament.HasFlag(item.Book.Testament)) {
                        if (col.Count <= limit)
                            col.Add(item);
                        else
                            break;
                    }
                }
            }
            return col;
        }

        KJBibleItem CreateBibleItem(KeyValuePair<string, string> data) {
            KJBibleItem item = new KJBibleItem();
            var split = data.Key.Split('|');
            item.Book = KJBibleBookDef.Find(split[0]).Value;
            item.Chapter = int.Parse(split[1]);
            item.Verse = int.Parse(split[2]);
            item.Scripture = data.Value;
            return item;
        }

        public KJBibleBookDef[] GetAllBookDef() {
            return KJBibleBookDef.GetAllBookDefs();
        }

        public KJBibleBookDef? GetBookDef(string bookName) {
            return KJBibleBookDef.Find(bookName);
        }

        private KJBibleItem CreateBibleItem(KJBibleBookDef def, KeyValuePair<string, string> data) {
            KJBibleItem item = new KJBibleItem();
            var split = data.Key.Split('|');
            item.Book = def;
            item.Chapter = int.Parse(split[1]);
            item.Verse = int.Parse(split[2]);
            item.Scripture = data.Value;
            return item;
        }

        public KJBibleCollection GetQuotations(string bookName, int chapterNum, int verseFromNum) {
            return GetQuotations(bookName, chapterNum, verseFromNum, 1);
        }
    }
}