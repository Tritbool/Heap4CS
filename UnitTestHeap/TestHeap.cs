using System;
using Heaps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHeap
{
    [TestClass]
    public class TestHeap
    {

        

        private HeapInterface<String>htest;
        
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }



        [TestInitialize]
        public void initialize()
        {
            this.htest = new Heap<String>();   
        }



        [TestMethod]
        public void creation_test()
        {                  
               htest = new Heap<String>();      
        }

        [TestMethod]
        public void add_test()
        {
            htest = new Heap<String>();
            this.htest.add("Test");
        }

        [TestMethod]
        public void get_test()
        {
            htest = new Heap<String>();
            this.htest.add("Test");

            String s = "yolo";
            s = this.htest.get_element_at(0);
            testContextInstance.WriteLine(s);

        }

    }
}
