using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmLesson4;

namespace TestTree
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Additem()
        {
            //arange
            TreeSearch nod = new TreeSearch();

            //act
            nod.AddItem(65);
            int testvalue = nod.root.Value;
            //assert
            Assert.AreEqual(testvalue, 65);

        }

        [TestMethod]
        public void GetNodeByValue()
        {
            //arange
            TreeSearch nod = new TreeSearch();

            nod.AddItem(65);
     
            //act
            var testnode = nod.root;
            var getnode = nod.GetNodeByValue(65);
            //assert
            Assert.AreEqual(testnode, getnode);

        }

        [TestMethod]
        public void Getroot()
        {
            //arange
            TreeSearch nod = new TreeSearch();

            nod.AddItem(65);
            nod.AddItem(85);
            nod.AddItem(118);

            //act
            var testnode = nod.GetRoot();

            //assert
            Assert.AreEqual(testnode, nod.root);

        }

        [TestMethod]
        public void Removeitem()
        {
            //arange
            TreeSearch nod = new TreeSearch();

            nod.AddItem(65);
            nod.AddItem(85);
            nod.AddItem(118);

            //act
            nod.RemoveItem(118);

            //assert
            Assert.AreEqual(null, nod.root.RightChild.RightChild);
            nod.AddItem(118);
            Assert.AreEqual(118, nod.root.RightChild.RightChild.Value);

        }

    }
}
