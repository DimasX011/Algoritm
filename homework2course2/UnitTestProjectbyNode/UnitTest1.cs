using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using homework2course2;
using quest2;

namespace UnitTestProjectbyNode
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAddnode()
        {
            //arange
            Noderealize testnode = new Noderealize();

            //act
            testnode.addNote(5);

            //assert
            Assert.AreEqual(5, testnode.Startnode.Value);

        }

        [TestMethod]
        public void Addnodeafter()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };

            //act
            testnode.addNote(root.Value);
            testnode.AddNodeAfter(root, 5);
            int sum = root.Value;
            int uio = root.NextNode.Value;

            //assert
            Assert.AreEqual((12,5,5),(sum,uio,5));

        }

        [TestMethod]
        public void Removenode()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };

            //act
            testnode.addNote(root.Value);
            testnode.AddNodeAfter(root, 5);
            testnode.RemoveNode(root);

            //assert
            Assert.AreEqual( 5, root.Value);

        }

        [TestMethod]
        public void RemovenodebyIndex()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };//1

            //act
            testnode.addNote(root.Value);//1
            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(15);//4
            testnode.RemoveNode(3);

            int roots = testnode.Startnode.Value;
            int rootsnext = testnode.Startnode.NextNode.Value;
            int rootsnextitem = testnode.Startnode.NextNode.NextNode.Value;
            
            //assert
            Assert.AreEqual((12,8,15),(roots, rootsnext, rootsnextitem));

        }

        [TestMethod]
        public void RemovenodebyIndex1()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };//1

            //act
            testnode.addNote(root.Value);//1
            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(15);//4
            testnode.RemoveNode(4);

            int roots = testnode.Startnode.Value;
            int rootsnext = testnode.Startnode.NextNode.Value;
            int rootsnextitem = testnode.Startnode.NextNode.NextNode.Value;

            //assert
            Assert.AreEqual((12, 8, 9), (roots, rootsnext, rootsnextitem));

        }

        [TestMethod]
        public void RemovenodebyIndex2()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 12 };//1

            //act
            testnode.addNote(root.Value);//1
            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(15);//4
            testnode.RemoveNode(1);

            int roots = testnode.Startnode.Value;
            int rootsnext = testnode.Startnode.NextNode.Value;
            int rootsnextitem = testnode.Startnode.NextNode.NextNode.Value;

            //assert
            Assert.AreEqual((8, 9, 15), (roots, rootsnext, rootsnextitem));

        }

        [TestMethod]
        public void RemovenodebyNode()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 17 };//1

            //act
            testnode.addNote(root.Value);//1
            testnode.addNote(12);//2
            testnode.addNote(14);//3
            testnode.addNote(16);//4
            testnode.RemoveNode(root);

            int roots = testnode.Startnode.Value;
            int rootsnext = testnode.Startnode.NextNode.Value;
            int rootsnextitem = testnode.Startnode.NextNode.NextNode.Value;

            //assert
            Assert.AreEqual((12, 14, 16), (roots, rootsnext, rootsnextitem));

        }

        [TestMethod]
        public void GetCount()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 17 };//1

            //act

            testnode.addNote(8);//5
            testnode.addNote(9);//6
            testnode.addNote(root.Value);//1
            testnode.addNote(root.Value);//4
            testnode.addNote(root.Value);//3
            testnode.addNote(root.Value);//2
            testnode.addNote(8);//7
            testnode.addNote(9);//8
            testnode.addNote(15);//9

            int count = testnode.GetCount();
        
            //assert
            Assert.AreEqual(9, count);

        }

        [TestMethod]
        public void Findnode()
        {
            //arange
            Noderealize testnode = new Noderealize();
            var root = new Node { Value = 17 };//1

            //act

            testnode.addNote(8);//2
            testnode.addNote(9);//3
            testnode.addNote(root.Value);//1
            testnode.addNote(10);//4
            testnode.addNote(12);//5
            testnode.addNote(14);//6

            var somenode = testnode.FindNode(17);

            //assert
            Assert.AreEqual(testnode.Startnode.NextNode.NextNode, somenode);

        }
        
        [TestMethod]
        public void BynarySearch_1()
        {
            //arange
            
            int[] poll = {10, 12, 15, 18, 21, 30 ,31, 35};
            
            int searchvalue = 30;
            int answer = 5;
            
            //act

            BynarySearch search = new BynarySearch();

            int expected = search.BinarySearch(poll, searchvalue);
            
            //assert
            Assert.AreEqual(expected, answer);
        }
        
        [TestMethod]
        public void BynarySearch_2()
        {
            //arange
            
            int[] poll = {52, 60, 63, 75, 80, 91, 100, 111, 125, 130, 140, 160};
            
            int searchvalue = 125;
            int answer = 8;
            
            //act

            BynarySearch search = new BynarySearch();

            int expected = search.BinarySearch(poll, searchvalue);
            
            //assert
            Assert.AreEqual(expected, answer);
        }
        
        [TestMethod]
        public void BynarySearch_3()
        {
            //arange
            
            int[] poll = {10, 12, 15, 18, 21, 30 ,31, 35};
            
            int searchvalue = 30;
            int answer = 5;
            
            //act

            BynarySearch search = new BynarySearch();

            int expected = search.BinarySearch(poll, searchvalue);
            
            //assert
            Assert.AreEqual(expected, answer);
        }
        
        
        [TestMethod]
        public void BynarySearch_4()
        {
            //arange
            
            int[] poll = {10, 18, 21, 25, 29, 31, 42, 48, 51, 60, 80};
            
            int searchvalue = 60;
            int answer = 9;
            
            //act

            BynarySearch search = new BynarySearch();

            int expected = search.BinarySearch(poll, searchvalue);
            
            //assert
            Assert.AreEqual(expected, answer);
        }
        
        [TestMethod]
        public void BynarySearch_5()
        {
            //arange
            
            int[] poll = {10, 12, 14, 61, 84, 125, 215, 300, 311, 400, 401};
            
            int searchvalue = 400;
            int answer = 9;
            
            //act

            BynarySearch search = new BynarySearch();

            int expected = search.BinarySearch(poll, poll[9]);
            
            //assert
            Assert.AreEqual(expected, answer);
        }


    }
}
