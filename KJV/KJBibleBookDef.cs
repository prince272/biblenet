using BibleNet.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV
{
    public struct KJBibleBookDef
    {
        private string bookName;
        private string abbreviation1;
        private string abbreviation2;
        private TestamentType testamentType;

        public KJBibleBookDef(string bookName, string abbreviation1, string abbreviation2, TestamentType testamentType)
        {
            this.bookName = bookName;
            this.abbreviation1 = abbreviation1;
            this.abbreviation2 = abbreviation2;
            this.testamentType = testamentType;
        }

        public string Book { get { return bookName; } }

        public string Abbreviation1 { get { return abbreviation1; } }

        public string Abbreviation2 { get { return abbreviation2; } }

        public TestamentType Testament { get { return testamentType; } }

        public static KJBibleBookDef[] GetAllBookDefs()
        {
            return new KJBibleBookDef[] { 
                new KJBibleBookDef("Genesis", "Gen.", "Gen", TestamentType.Old),
                new KJBibleBookDef("Exodus", "Ex.", "Exo", TestamentType.Old),
                new KJBibleBookDef("Leviticus", "Lev.", "Lev", TestamentType.Old),
                new KJBibleBookDef("Numbers", "Num.", "Num", TestamentType.Old),
                new KJBibleBookDef("Deuteronomy", "Deut.", "Deu", TestamentType.Old),
                new KJBibleBookDef("Joshua", "Josh.", "Jos", TestamentType.Old),
                new KJBibleBookDef("Judges", "Judg.", "Jdg", TestamentType.Old),
                new KJBibleBookDef("Ruth", "Ruth", "Rut", TestamentType.Old),
                new KJBibleBookDef("1 Samuel", "1 Sam.", "Sa1", TestamentType.Old),
                new KJBibleBookDef("2 Samuel", "2 Sam.", "Sa2", TestamentType.Old),
                new KJBibleBookDef("1 Kings", "1 Kings", "Kg1", TestamentType.Old),
                new KJBibleBookDef("2 Kings", "2 Kings", "Kg2", TestamentType.Old),
                new KJBibleBookDef("1 Chronicles", "1 Chron.", "Ch1", TestamentType.Old),
                new KJBibleBookDef("2 Chronicles", "2 Chron.", "Ch2", TestamentType.Old),
                new KJBibleBookDef("Ezra", "Ezra", "Ezr", TestamentType.Old),
                new KJBibleBookDef("Nehemiah", "Neh.", "Neh", TestamentType.Old),
                new KJBibleBookDef("Esther", "Est.", "Est", TestamentType.Old),
                new KJBibleBookDef("Job", "Job", "Job", TestamentType.Old),
                new KJBibleBookDef("Psalms", "Ps.", "Psa", TestamentType.Old),
                new KJBibleBookDef("Proverbs", "Prov.", "Pro", TestamentType.Old),
                new KJBibleBookDef("Ecclesiastes", "Eccles.", "Ecc", TestamentType.Old),
                new KJBibleBookDef("Song of Solomon", "Song", "Sol", TestamentType.Old),
                new KJBibleBookDef("Isaiah", "Isa.", "Isa", TestamentType.Old),
                new KJBibleBookDef("Jeremiah", "Jer.", "Jer", TestamentType.Old),
                new KJBibleBookDef("Lamentations", "Lam.", "Lam", TestamentType.Old),
                new KJBibleBookDef("Ezekiel", "Ezek.", "Eze", TestamentType.Old),
                new KJBibleBookDef("Daniel", "Dan.", "Dan", TestamentType.Old),
                new KJBibleBookDef("Hosea", "Hos.", "Hos", TestamentType.Old),
                new KJBibleBookDef("Joel", "Joel", "Joe", TestamentType.Old),
                new KJBibleBookDef("Amos", "Amos", "Amo", TestamentType.Old),
                new KJBibleBookDef("Obadiah", "Obad.", "Oba", TestamentType.Old),
                new KJBibleBookDef("Jonah", "Jonah", "Jon", TestamentType.Old),
                new KJBibleBookDef("Micah", "Mic.", "Mic", TestamentType.Old),
                new KJBibleBookDef("Nahum", "Nah.", "Nah", TestamentType.Old),
                new KJBibleBookDef("Habakkuk", "Hab.", "Hab", TestamentType.Old),
                new KJBibleBookDef("Zephaniah", "Zeph.", "Zep", TestamentType.Old),
                new KJBibleBookDef("Haggai", "Hag.", "Hag", TestamentType.Old),
                new KJBibleBookDef("Zechariah", "Zech.", "Zac", TestamentType.Old),
                new KJBibleBookDef("Malachi", "Mal.", "Mal", TestamentType.Old),

                new KJBibleBookDef("Matthew", "Matt.", "Mat", TestamentType.New),
                new KJBibleBookDef("Mark", "Mark", "Mar", TestamentType.New),
                new KJBibleBookDef("Luke", "Luke", "Luk", TestamentType.New),
                new KJBibleBookDef("John", "John", "Joh", TestamentType.New),
                new KJBibleBookDef("Acts", "Acts", "Act", TestamentType.New),
                new KJBibleBookDef("Romans", "Rom.", "Rom", TestamentType.New),
                new KJBibleBookDef("1 Corinthians", "1 Cor.", "Co1", TestamentType.New),
                new KJBibleBookDef("2 Corinthians", "2 Cor.", "Co2", TestamentType.New),
                new KJBibleBookDef("Galatians", "Gal.", "Gal", TestamentType.New),
                new KJBibleBookDef("Ephesians", "Eph.", "Eph", TestamentType.New),
                new KJBibleBookDef("Philippians", "Phil.", "Phi", TestamentType.New),
                new KJBibleBookDef("Colossians", "Col.", "Col", TestamentType.New),
                new KJBibleBookDef("1 Thessalonians", "1 Thess.", "Th1", TestamentType.New),
                new KJBibleBookDef("2 Thessalonians", "2 Thess.", "Th2", TestamentType.New),
                new KJBibleBookDef("1 Timothy", "1 Tim.", "Ti1", TestamentType.New),
                new KJBibleBookDef("2 Timothy", "2 Tim.", "Ti2", TestamentType.New),
                new KJBibleBookDef("Titus", "Titus", "Tit", TestamentType.New),
                new KJBibleBookDef("Philemon", "Philem.", "Plm", TestamentType.New),
                new KJBibleBookDef("Hebrews", "Heb.", "Heb", TestamentType.New),
                new KJBibleBookDef("James", "James", "Jam", TestamentType.New),
                new KJBibleBookDef("1 Peter", "1 Pet.", "Pe1", TestamentType.New),
                new KJBibleBookDef("2 Peter", "2 Pet.", "Pe2", TestamentType.New),
                new KJBibleBookDef("1 John", "1 John", "Jo1", TestamentType.New),
                new KJBibleBookDef("2 John", "2 John", "Jo2", TestamentType.New),
                new KJBibleBookDef("3 John", "3 John", "Jo3", TestamentType.New),
                new KJBibleBookDef("Jude", "Jude", "Jde", TestamentType.New),
                new KJBibleBookDef("Revelation", "Rev.", "Rev", TestamentType.New),
            };
        }

        internal static KJBibleBookDef? Find(string bookName)
        {
            foreach (var def in GetAllBookDefs())
            {
                if (StringsEqual(def.bookName, bookName, false))
                    return def;
                else if (StringsEqual(def.abbreviation1, bookName, false))
                    return def;
                else if (StringsEqual(def.abbreviation2, bookName, true))
                    return def;
            }
            return null;
        }
        
        static bool StringsEqual(string botstring, string userstring, bool switchNum)
        {
            char[] trimChars = new char[2];
            if ((botstring != "John") &&
                (botstring != "Joh") &&
                (botstring != "1 John") &&
                (botstring != "Joh1"))
                trimChars[1] = '1';
            trimChars[0] = '.';
            botstring = botstring.RemoveSpaces().Trim(trimChars);
            userstring = userstring.RemoveSpaces().Trim(trimChars);
            char firstChar = userstring.FirstOrDefault();
            if (char.IsDigit(firstChar) && switchNum)
            {
                userstring = userstring.TrimStart(firstChar);
                userstring = userstring + firstChar;
            }
            return string.Equals(botstring, userstring, StringComparison.OrdinalIgnoreCase);
        }
    }
}