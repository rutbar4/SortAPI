namespace HomeWorkTask.Utils
{
    public static class Validation
    {
        public static bool IsRangeValid(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if (number < 1 || number > 10) { return false; }
            }
            return true;
        }
    }
}