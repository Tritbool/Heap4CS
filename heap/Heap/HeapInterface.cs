using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
   public interface HeapInterface<T>
    {
        void add(T obj);
        void remove(T obj);
        T get_element_at(int idx);
        T search(T obj);
        void sort(IComparer<T> cmp);
    }
}
