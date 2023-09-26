using HomeWorkTask.DTO;

namespace HomeWorkTask.Utils
{
    public static class InOutUtils
    {
        private static readonly string _filePath = Environment.CurrentDirectory.ToString() + @"\Results\result.txt";

        public static void WriteToFile(NumbersItem numbersItem)
        {
            if (numbersItem.Numbers is not null)
            {
                using StreamWriter sw = new(_filePath, false);
                foreach (int number in numbersItem.Numbers)
                    sw.WriteLine(number);
            }
        }

        public static NumbersItem? ReadResults()
        {
            if (!File.Exists(_filePath))
                return null;

            var numbersList = new List<int>();
            string[] lines = File.ReadAllLines(_filePath);

            foreach (string line in lines)
            {
                numbersList.Add(int.Parse(line));
            }

            var numbersArray = new NumbersItem() { Numbers = numbersList.ToArray() };
            return numbersArray;
        }
    }
}