using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0011
    /// </summary>
    [TestClass]
    public class Problem_0011
    {
        [TestMethod]
        public void Solution_0011()
        {
            // Act
            var result = Solutions.Problem_0011.Solve();

            // Assert
            Assert.AreEqual(70600674, result);
        }
    }
}
