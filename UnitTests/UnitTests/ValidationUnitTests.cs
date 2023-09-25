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

        [Test]
        public void IsRangeValid_MoreThan10_false()
        {
            // Arrange 
            int[] invalidInput = { 3, 2, 11, 4, 1 };

            // Act
            var result = Validation.IsRangeValid(invalidInput);

            // Assert
            Assert.That(result, Is.False);
        }
        
        [Test]
        public void IsRangeValid_LessThan1_false()
        {
            // Arrange 
            int[] invalidInput = { 3, 2, 0, 1 };

            // Act
            var result = Validation.IsRangeValid(invalidInput);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void IsRangeValid_LessThan1AndMoreThan10_false()
        {
            // Arrange 
            int[] invalidInput = { 15, 2, 0, 1 };

            // Act
            var result = Validation.IsRangeValid(invalidInput);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
