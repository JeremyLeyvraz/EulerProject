using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0005
    /// </summary>
    [TestClass]
    public class Problem_0005
    {
        [TestMethod]
        public void Solution_0005()
        {
            // Act
            var result = Solutions.Problem_0005.Solve();

            // Assert
            Assert.AreEqual(232792560, result);
        }
    }
}
