using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solutions.UnitTests
{
    /// <summary>
    /// Solution for Problem_0001
    /// </summary>
    [TestClass]
    public class Problem_0001
    {
        [TestMethod]
        public void Solution_0001()
        {
            // Arrange
            var threshold = 1000;
            var dividers = new List<int> { 3, 5 };

            // Act
            var result = Solutions.Problem_0001.Solve(threshold, dividers);

            // Assert
            Assert.AreEqual(233168, result);
        }
    }
}
