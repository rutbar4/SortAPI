using HomeWorkTask.Utils;

namespace Tests.UnitTests
{
    internal class ValidationUnitTests
    {
        [Test]
        public void IsRangeValid_ValidRange_true()
        {
            // Arrange
            int[] validInput = { 3, 2, 9, 4, 1, 10 };

            // Act
            var result = Validation.IsRangeValid(validInput);

            // Assert
            Assert.That(result, Is.True);
        }

        [TestCase(new int[] { 3, 2, 11, 4, 1 })]
        [TestCase(new int[] { 3, 2, 0, 1 })]
        [TestCase(new int[] { 15, 2, 0, 1 })]
        public void IsRangeValid_WrongRange_false(int[] invalidInput)
        {
            // Act
            var result = Validation.IsRangeValid(invalidInput);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}