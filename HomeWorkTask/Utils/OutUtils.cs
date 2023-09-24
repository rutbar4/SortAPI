namespace HomeWorkTask.Utils
{
    public static class OutUtils
    {
        private static readonly string filePath = Environment.CurrentDirectory.ToString() + @"\Results";
        private static readonly string fileName = "result.txt";

        public static void WriteToFile(int[] numbers)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), false))
            {
                foreach (int number in numbers)
                    sw.WriteLine(number);
            }
        }
    }
}