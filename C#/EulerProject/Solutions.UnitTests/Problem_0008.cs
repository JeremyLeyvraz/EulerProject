using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0008
    /// </summary>
    [TestClass]
    public class Problem_0008
    {
        [TestMethod]
        public void Solution_0008()
        {
            // Act
            var result = Solutions.Problem_0008.Solve();

            // Assert
            Assert.AreEqual((ulong)23514624000, result);
        }
    }
}
