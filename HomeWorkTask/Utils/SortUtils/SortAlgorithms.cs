namespace HomeWorkTask.Utils.SortUtils
{
    public static class SortAlgorithms
    {
        public static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        (input[j], input[i]) = (input[i], input[j]);
                    }
                }
            }
            return input;
        }

        public static int[] InsertionSort(int[] input) //copied
        {
            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && input[currentIndex - 1] > item)
                {
                    input[currentIndex] = input[currentIndex - 1];
                    currentIndex--;
                }

                input[currentIndex] = item;
            }
            return input;
        }

        public static List<int> InsertionSort(List<int> input) //copied
        {
            var clonedList = new List<int>(input.Count);

            for (int i = 0; i < input.Count; i++)
            {
                var item = input[i];
                var currentIndex = i;

                while (currentIndex > 0 && clonedList[currentIndex - 1] > item)
                {
                    currentIndex--;
                }

                clonedList.Insert(currentIndex, item);
            }

            return clonedList;
        }
    }
}
