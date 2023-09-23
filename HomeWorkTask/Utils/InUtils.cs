namespace HomeWorkTask.Utils
{
    public static class InUtils
    {
        public static int[] ReadResults()
        {
        string pathSource = @"C:\Users\RUTA\Desktop\HW task\HomeWorkTask\HomeWorkTask\Results\result.txt";
            var numbersList = new List<int>();
            try
            {
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(pathSource))
                {
                    string line;
                    // Read the stream as a string, and write the string to the console.
                    while((line = sr.ReadLine()) is not null)
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
