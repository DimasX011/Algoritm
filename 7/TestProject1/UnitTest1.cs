using Microsoft.VisualStudio.TestTools.UnitTesting;
using DynamicProgs;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DynamicProges()
        {
            //arrange
            int N = 8;
            int M = 8;

            //act
            DynamicProgs.DynamicProgs progs = new DynamicProgs.DynamicProgs();

            int answer = progs.Dynamicprogs(N, M);

            //assert
            Assert.AreEqual(1338, answer);

         


        }
    }
}
