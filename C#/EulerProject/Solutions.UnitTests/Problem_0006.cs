using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0006
    /// </summary>
    [TestClass]
    public class Problem_0006
    {
        [TestMethod]
        public void Solution_0006()
        {
            // Act
            var result = Solutions.Problem_0006.Solve();

            // Assert
            Assert.AreEqual(25164150, result);
        }
    }
}
