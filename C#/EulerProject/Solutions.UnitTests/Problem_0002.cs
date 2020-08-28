using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution for Problem_0002
    /// </summary>
    [TestClass]
    public class Problem_0002
    {
        [TestMethod]
        public void Solution_0002()
        {
            // Act
            var result = Solutions.Problem_0002.Solve();

            // Assert
            Assert.AreEqual(4613732, result);
        }
    }
}
