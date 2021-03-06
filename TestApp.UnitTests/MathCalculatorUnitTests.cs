using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestApp.UnitTests
{

    // MSTest
    
    [TestClass]
    public class MathCalculatorUnitTests
    {
        private MathCalculator mathCalculator;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            mathCalculator = new MathCalculator();
        }


        // Method_Scenario_Behavior


        [TestMethod]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            // Arrange

            // Act
            var result = mathCalculator.Add(1, 2);

            // Assert
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            // Arrange

            // Act
            var result = mathCalculator.Max(2, 1);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_SecondsArgumentIsGreater_ReturnsTheSecondArgument()
        {
            // Arrange

            // Act
            var result = mathCalculator.Max(1, 2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArgument()
        {
            // Arrange

            // Act
            var result = mathCalculator.Max(1, 1);

            // Assert
            Assert.AreEqual(1, result);
        }

        [DataRow(2, 1, 2, DisplayName = "FirstArgumentIsGreater_ReturnsTheFirstArgument")]
        [DataRow(1, 2, 2, DisplayName = "Max_SecondsArgumentIsGreater_ReturnsTheSecondArgument")]
        [DataRow(1, 1, 1, DisplayName = "Max_ArgumentsAreEqual_ReturnsTheSameArgument")]
        [DataTestMethod]
        public void Max_Arguments_ReturnsValidArgument(int first, int second, int expected)
        {
            // Arrange

            // Act
            var result = mathCalculator.Max(first, second);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
