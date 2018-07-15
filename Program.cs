using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet {
    class Program {
        static void Main() {
            var sss = new KJV.KJBible().GetQuotations("2 sam");
        }
    }
}