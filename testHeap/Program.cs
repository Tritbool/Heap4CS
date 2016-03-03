using Heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testHeap
{
    class Program
    {
       
        static void Main(string[] args)
        {
        HeapInterface<String> test;
        test = new Heap<String>();
            test.add("Test");

            String s = "yolo";
            s = test.get_element_at(0);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
