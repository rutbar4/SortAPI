namespace HomeWorkTask.Utils
{
    public static class OutUtils
    {
        public static void WriteToFile(int[] numbers)
        {
            var filePath =  Environment.CurrentDirectory.ToString() + @"\Results"; 
            var fileName = "result.txt";

            using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), false))
            {
                foreach (int number in numbers)
                    sw.WriteLine(number);
            }

        }
    }
}
