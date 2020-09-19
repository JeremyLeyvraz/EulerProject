using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0012
    /// </summary>
    [TestClass]
    public class Problem_0012
    {
        [TestMethod]
        public void Solution_0012()
        {
            // Act
            var result = Solutions.Problem_0012.Solve();

            // Assert
            Assert.AreEqual(76576500, result);
        }
    }
}
