using Microsoft.VisualStudio.TestPlatform.TestHost;
using simpleSummationLibrary;

namespace simpleSummation.Tests
{
    public class simpleSummationTests
    {
        [Fact]
        public void Test1()
        {
            var simpleSumm = new SimpleSummation();

            int[] ints = new int[] { 5, 2, 3 };

            Assert.Equal(5, simpleSumm.SumOfTwoSmallest(ints));

        }
    }
}