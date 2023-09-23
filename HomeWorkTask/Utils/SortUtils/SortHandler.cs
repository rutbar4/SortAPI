﻿using System.Diagnostics;

namespace HomeWorkTask.Utils.SortUtils
{
    public static class SortHandler
    {
        public static int[] sortNumbers(int[] numbers)
        {
            var resultBubbleSort = BubbleSortAndTimer(numbers);
            var resultInsetionSort = InsetionSortAndTimer(numbers);
            var resultInsrtionSortNew = InsrtionSortNewAndTimer(numbers);

            return resultBubbleSort;
        }

        private static int[] BubbleSortAndTimer(int[] numbers)
        {
            var watchBubble = System.Diagnostics.Stopwatch.StartNew();

            var result = SortAlgorithms.BubbleSort(numbers);
            watchBubble.Stop();
            var elapsedMsBubble = watchBubble.Elapsed.TotalMilliseconds;

            Console.WriteLine($"Bubble time: {@elapsedMsBubble}");
            return result;
        }

        private static int[] InsrtionSortNewAndTimer(int[] numbers)
        {
            var watchInsertionSortNew = System.Diagnostics.Stopwatch.StartNew();

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
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var result = SortAlgorithms.InsertionSort(numbers);

            watch.Stop();
            var elapsedMsInsertionSort = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine($"InsertionSort time: {@elapsedMsInsertionSort}");

            return result;
        }
    }
}
