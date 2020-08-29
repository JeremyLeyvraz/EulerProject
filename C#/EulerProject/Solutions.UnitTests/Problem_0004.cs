using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0004
    /// </summary>
    [TestClass]
    public class Problem_0004
    {
        [TestMethod]
        public void Solution_0004()
        {
            // Act
            var result = Solutions.Problem_0004.Solve();

            // Assert
            Assert.AreEqual(906609, result);
        }
    }
}
