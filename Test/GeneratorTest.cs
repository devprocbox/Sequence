using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SequenceGenerator;

namespace Test {
    [TestClass]
    public class GeneratorTest {

        [TestMethod]
        public void ZeroAtIndexZero()
        {
            Assert.IsTrue(1 == Generator.Tribonacci(0));
        }

        [TestMethod]
        public void OneAtIndexOne()
        {
            Assert.IsTrue(1 == Generator.Tribonacci(1));
        }

        [TestMethod]
        public void TestSequence()
        {
            int[] expected = new int[] { 1, 1, 2, 4, 7, 13, 24, 44, 81, 149 };
            int[] calculated = new int[expected.Length];
            for (int i = 0; i < expected.Length; i++)
            {
                calculated[i] = Generator.Tribonacci(i);
            }
            Assert.IsTrue(Enumerable.SequenceEqual(expected, calculated));
        }
    }
}
