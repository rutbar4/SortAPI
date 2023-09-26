using HomeWorkTask.DTO;
using System.Diagnostics;

namespace HomeWorkTask.Utils.SortUtils
{
    public static class SortHandler
    {
        public static NumbersItem SortNumbers(NumbersItem numbersItem)
        {
            var numbers = numbersItem.Numbers ?? Array.Empty<int>();

            var resultBubbleSort = BubbleSortAndTimer(numbers);
            var resultInsetionSort = InsertionSortAndTimer(numbers); //for timer accuracy
            var resultInsrtionSortNew = InsertionSortNewAndTimer(numbers); //for timer accuracy

            return new NumbersItem() { Numbers = resultBubbleSort };
        }

        private static int[] BubbleSortAndTimer(int[] numbers)
        {
            var watchBubble = Stopwatch.StartNew();

            var result = SortAlgorithms.BubbleSort(numbers);
            watchBubble.Stop();
            var elapsedMsBubble = watchBubble.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Bubble time: {@elapsedMsBubble}");
            return result;
        }

        private static int[] InsertionSortNewAndTimer(int[] numbers)
        {
            var watchInsertionSortNew = Stopwatch.StartNew();

            var numbersList = numbers.ToList();
            var resultList = SortAlgorithms.InsertionSort(numbersList);

            watchInsertionSortNew.Stop();
            var elapsedMsInsertionSortNew = watchInsertionSortNew.Elapsed.TotalMilliseconds;
            Console.WriteLine($"InsertionSortNew time: {@elapsedMsInsertionSortNew}");

            var result = resultList.ToArray();
            return result;
        }

        private static int[] InsertionSortAndTimer(int[] numbers)
        {
            var watch = Stopwatch.StartNew();

            var result = SortAlgorithms.InsertionSort(numbers);

            watch.Stop();
            var elapsedMsInsertionSort = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine($"InsertionSort time: {@elapsedMsInsertionSort}");

            return result;
        }
    }
}