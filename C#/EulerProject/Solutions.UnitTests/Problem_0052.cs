using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0052
    /// </summary>
    [TestClass]
    public class Problem_0052
    {
        [TestMethod]
        public void Solution_0052()
        {
            // Act
            var result = Solutions.Problem_0052.Solve();

            // Assert
            Assert.AreEqual(142857, result);
        }
    }
}
