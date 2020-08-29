using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution of Problem_0003
    /// </summary>
    [TestClass]
    public class Problem_0003
    {
        [TestMethod]
        public void Solution_0003()
        {
            // Act
            var result = Solutions.Problem_0003.Solve(600851475143);

            // Assert
            Assert.AreEqual(6857, result);
        }
    }
}
