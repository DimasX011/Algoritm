using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExternalSort;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExternalSort()
        {
            //arrange
            int[] chisla = new int[15] { 43, 17, 87, 92, 31, 6, 96, 13, 66, 62, 4, 5, 8, 12, 16 };
            int[] answer = new int[15] { 4, 5, 6, 8, 12, 13, 16, 17, 31, 43, 62, 66, 87, 92, 96 };
            //act

            Externalsort externalsort = new Externalsort();
            int[] arrayanswer = externalsort.Externalsorted(chisla);

            //assert
            CollectionAssert.AreEqual(arrayanswer, answer);
           

        }
    }
}
