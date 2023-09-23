namespace HomeWorkTask.Utils.SortUtils
{
    public static class SortHandler
    {
        public static int[] sortNumbers(int[] numbers)
        {
            var resultBubbleSort = SortAlgorithms.BubbleSort(numbers);
            var resultInsertionSort = SortAlgorithms.InsertionSort(numbers);

            var numbersList = numbers.ToList();
            var resultInsertionSortNew = SortAlgorithms.InsertionSortNew(numbersList);

            return resultBubbleSort;
        }
    }
}
