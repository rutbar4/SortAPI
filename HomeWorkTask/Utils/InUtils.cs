namespace HomeWorkTask.Utils
{
    public static class InUtils
    {
        public static int[] ReadResults()
        {
            string pathSource = Environment.CurrentDirectory.ToString() + @"\Results\result.txt";
            Console.WriteLine(Environment.CurrentDirectory.ToString());
            
            var numbersList = new List<int>();
            try
            {
                using (var sr = new StreamReader(pathSource))
                {
                    string line;
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
