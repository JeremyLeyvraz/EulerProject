using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0010
    /// </summary>
    [TestClass]
    public class Problem_0010
    {
        [TestMethod]
        public void Solution_0010()
        {
            // Act
            var result = Solutions.Problem_0010.Solve();

            // Assert
            Assert.AreEqual((ulong)142913828922, result);
        }
    }
}
