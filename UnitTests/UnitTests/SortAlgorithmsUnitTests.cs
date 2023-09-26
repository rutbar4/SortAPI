using HomeWorkTask.Utils.SortUtils;

namespace UnitTests.ControllersUnitTests
{
    public class Tests
    {
        private readonly int[] _inputNumbers = { 3, 1, 2, 40, 2, 25, -3, -100 };

        [Test]
        public void BubbleSort_NumbersArray_IsCorrectlyOrdered()
        {
            // Act
            var outputNumbers = SortAlgorithms.BubbleSort(_inputNumbers);

            // Assert
            Assert.That(outputNumbers, Has.Length.EqualTo(_inputNumbers.Length));
            Assert.That(outputNumbers, Is.Ordered);
        }

        [Test]
        public void InsertionSort_NumbersArray_IsCorrectlyOrdered()
        {
            // Act
            var outputNumbers = SortAlgorithms.InsertionSort(_inputNumbers);

            // Assert
            Assert.That(outputNumbers, Has.Length.EqualTo(_inputNumbers.Length));
            Assert.That(outputNumbers, Is.Ordered);
        }

        [Test]
        public void InsertionSortNew_NumbersList_IsCorrectlyOrdered()
        {
            // Arrange
            var inputNumbersList = _inputNumbers.ToList();

            // Act
            var outputNumbers = SortAlgorithms.InsertionSort(inputNumbersList);

            // Assert
            Assert.That(outputNumbers, Has.Count.EqualTo(inputNumbersList.Count));
            Assert.That(outputNumbers, Is.Ordered);
        }
    }
}