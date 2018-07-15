using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    public class KJBibleException : Exception {
        public KJBibleException(string message)
            : base(message) {

        }
    }
}