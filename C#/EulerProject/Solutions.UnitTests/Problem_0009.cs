using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0009
    /// </summary>
    [TestClass]
    public class Problem_0009
    {
        [TestMethod]
        public void Solution_0009()
        {
            // Act
            var result = Solutions.Problem_0009.Solve();

            // Assert
            Assert.AreEqual(31875000, result);
        }
    }
}
