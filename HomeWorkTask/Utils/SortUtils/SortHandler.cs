using System.Diagnostics;

namespace HomeWorkTask.Utils.SortUtils
{
    public static class SortHandler
    {
        public static int[] SortNumbers(int[] numbers)
        {
            var resultBubbleSort = BubbleSortAndTimer(numbers);
            var resultInsetionSort = InsetionSortAndTimer(numbers); //for timer accuracy
            var resultInsrtionSortNew = InsrtionSortNewAndTimer(numbers); //for timer accuracy

            return resultBubbleSort;
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

        private static int[] InsrtionSortNewAndTimer(int[] numbers)
        {
            var watchInsertionSortNew = Stopwatch.StartNew();

            var numbersList = numbers.ToList();
            var resultList = SortAlgorithms.InsertionSortNew(numbersList);

            watchInsertionSortNew.Stop();
            var elapsedMsInsertionSortNew = watchInsertionSortNew.Elapsed.TotalMilliseconds;
            Console.WriteLine($"InsertionSortNew time: {@elapsedMsInsertionSortNew}");

            var result = resultList.ToArray();
            return result;
        }

        private static int[] InsetionSortAndTimer(int[] numbers)
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
