using Microsoft.VisualStudio.TestPlatform.TestHost;
using simpleSummationLibrary;

namespace simpleSummation.Tests
{
    public class simpleSummationTests
    {
        [Fact]
        public void Test1Summ()
        {
            var simpleSumm = new SimpleSummation();

            var ints = new int[] { 5, 2, 3 };

            Assert.Equal(5, simpleSumm.SumTwoMin(ints));

        }

        [Fact]
        public void Test2Empty()
        {
            var simpleSumm = new SimpleSummation();

            var ints = new int[] { };

            Assert.Equal(0, simpleSumm.SumTwoMin(ints));

        }

        [Fact]
        public void Test3NegativeSumm()
        {
            var simpleSumm = new SimpleSummation();

            var ints = new int[] {-1, -5, -7 };

            Assert.Equal(-12, simpleSumm.SumTwoMin(ints));

        }


        [Fact]
        public void Test4Alone()
        {
            var simpleSumm = new SimpleSummation();

            var ints = new int[] { -1 };

            Assert.Equal(-1, simpleSumm.SumTwoMin(ints));

        }
    }
}