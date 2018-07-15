using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleNet.KJV {
    public class KJBibleCollection : CollectionBase, IEnumerable<KJBibleItem> {
        public void Add(KJBibleItem item) {
            List.Add(item);
        }

        public new IEnumerator<KJBibleItem> GetEnumerator() {
            var enumerator = InnerList.GetEnumerator();
            while (enumerator.MoveNext()) {
                yield return (KJBibleItem)enumerator.Current;
            }
        }
    }
}