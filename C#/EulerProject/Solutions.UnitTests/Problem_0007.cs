using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0007
    /// </summary>
    [TestClass]
    public class Problem_0007
    {
        [TestMethod]
        public void Solution_0007()
        {
            // Act
            var result = Solutions.Problem_0007.Solve();

            // Assert
            Assert.AreEqual(104743, result);
        }
    }
}
