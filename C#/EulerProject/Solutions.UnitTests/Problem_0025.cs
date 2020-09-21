using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0025
    /// </summary>
    [TestClass]
    public class Problem_0025
    {
        [TestMethod]
        public void Solution_0025()
        {
            // Act
            var result = Solutions.Problem_0025.Solve();

            // Assert
            Assert.AreEqual(4782, result);
        }
    }
}
