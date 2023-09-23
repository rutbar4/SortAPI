namespace HomeWorkTask.Utils
{
    public static class OutUtils
    {
        public static void WriteToFile(int[] numbers)
        {
            string filePath = @"C:\Users\RUTA\Desktop\HW task\HomeWorkTask\HomeWorkTask\Results"; //needs relative path
            string fileName = "result.txt";

            using (StreamWriter sw = new StreamWriter(Path.Combine(filePath, fileName), true))
            {
                foreach (int number in numbers)
                    sw.WriteLine($"{@number} ");
            }

        }
    }
}
