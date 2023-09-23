namespace HomeWorkTask
{
    public class SortAlgorithms
    {
        //static?
        public void BubbleSort(int[] input)
        {
            var itemMoved = false;
            do
            {
                itemMoved = false;
                for (int i = 0; i < input.Count() - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        var lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;
                    }
                }
            } while (itemMoved);
        }

        public void InsertionSort(int[] input)
        {

            for (int i = 0; i < input.Count(); i++)
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
        }

        public List<int> InsertionSortNew(this List<int> input)
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
