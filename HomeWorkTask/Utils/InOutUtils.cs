namespace HomeWorkTask.Utils
{
    public static class InOutUtils
    {
        private static readonly string _filePath = Environment.CurrentDirectory.ToString() + @"\Results";
        private static readonly string _fileName = "result.txt";
        public static void WriteToFile(int[] numbers)
        {
            using (StreamWriter sw = new StreamWriter(Path.Combine(_filePath, _fileName), false))
            {
                foreach (int number in numbers)
                    sw.WriteLine(number);
            }
        }

        public static int[] ReadResults()
        {
            var numbersList = new List<int>();
            try 
            {
                using (var sr = new StreamReader($@"{_filePath}\{_fileName}"))
                {
                    string? line;
                    while ((line = sr.ReadLine()) is not null)
                    {
                        numbersList.Add(int.Parse(line));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            var numbersArray = numbersList.ToArray();
            return numbersArray;
        }
    }
}