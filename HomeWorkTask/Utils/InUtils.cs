namespace HomeWorkTask.Utils
{
    public static class InUtils
    {
        private static readonly string PathSource = Environment.CurrentDirectory.ToString() + @"\Results\result.txt";

        public static int[] ReadResults()
        {
            var numbersList = new List<int>();
            try 
            {
                using (var sr = new StreamReader(PathSource))
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