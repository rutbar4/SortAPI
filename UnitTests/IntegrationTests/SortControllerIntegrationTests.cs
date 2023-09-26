using HomeWorkTask.Controllers;
using HomeWorkTask.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Tests.IntegrationTests
{
    internal class SortControllerIntegrationTests
    {
        private readonly NumbersItem _numbersItem = new() { Numbers = new int[] { 3, 9, 2, 1 } };
        private readonly SortController _sortController = new();

        [Test]
        public void SortNumbers_validInput_200()
        {
            //Act
            var result = _sortController.SortNumbers(_numbersItem);

            //Assert
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        [TestCase(new int[] { 3, 2, 11, 1 })]
        [TestCase(new int[] { 3, 2, -5, 1 })]
        [TestCase(new int[] { 3, 2, 15, -1 })]
        [TestCase(new int[] { 3, 2, 15, -1 })]
        [TestCase(new int[] { 3, 2, 15, -1 })]
        public void SortNumbers_validInput_400(int[] invalidInput)
        {
            // Arrange
            NumbersItem invalidNumbersItem = new() { Numbers = invalidInput };

            //Act
            var result = _sortController.SortNumbers(invalidNumbersItem);

            //Assert
            Assert.That(result, Is.InstanceOf<BadRequestObjectResult>());
        }

        [Test]
        public void Numbers_SuccessfulRead_200()
        {
            //Act
            var sortedNumbers = _sortController.SortNumbers(_numbersItem) as OkObjectResult;
            var okSorted = sortedNumbers?.Value as NumbersItem;

            var result = _sortController.Numbers() as OkObjectResult;
            var okResult = result?.Value as NumbersItem;

            //Assert
            Assert.That(result, Is.InstanceOf<OkObjectResult>());
            Assert.That(okSorted?.Numbers, Is.EqualTo(okResult?.Numbers));
        }
    }
}