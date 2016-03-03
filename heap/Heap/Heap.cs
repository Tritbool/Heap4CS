using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaps
{
    

    public class Heap<T> : HeapInterface<T>
    {
        public class Element
        {
            private T elt;
            private int idx;

            public void set_elt(T obj) {
                this.elt = obj;
            }

            public T get_elt()
            {
                return this.elt;
            }

            public void set_idx(int idx)
            {
                this.idx = idx;
            }

            public int get_idx()
            {
                return this.idx;
            }

        }

        protected List<Element> root { get; set; }
        protected int current { get; set; }
        protected Boolean next { get; set; }


        public Heap() {
            root = new List<Element>();
            current = 0;
            next = false;
        }

        private void update_next() {
            next = !next;
        }

        void HeapInterface<T>.add(T obj)
        {
            Element elem = new Element();
            elem.set_elt(obj);
            Console.WriteLine(current);
            elem.set_idx(current++);
            Console.WriteLine(current);
            



            this.root.Add(elem);
            //throw new NotImplementedException();
        }

        void HeapInterface<T>.remove(T obj)
        {
            throw new NotImplementedException();
        }

        T HeapInterface<T>.get_element_at(int idx)
        {
            Element elt = root.ElementAt(idx);
            return elt.get_elt();
        }


        T HeapInterface<T>.search(T obj)
        {
            throw new NotImplementedException();
        }

        void HeapInterface<T>.sort(IComparer<T> cmp)
        {
            throw new NotImplementedException();
        }
    }
}
