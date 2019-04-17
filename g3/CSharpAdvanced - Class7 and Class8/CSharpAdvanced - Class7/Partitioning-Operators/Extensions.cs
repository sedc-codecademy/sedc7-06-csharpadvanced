using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitioning_Operators {
    public static class Extensions {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> sequence, int count) {
            int q = 0;
            Queue<T> queue = new Queue<T>();
            foreach (var item in sequence) {
                queue.Enqueue(item);
                if (q < count)
                    q++;
                else
                    queue.Dequeue();
            }
            return queue;
        }

        public static IEnumerable<T> TakeLast2<T>(this IEnumerable<T> sequence, int count) {
            int n = sequence.Count() > count ? sequence.Count() - count : sequence.Count();
            return sequence.Skip(n);
        }
    }
}
