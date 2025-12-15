using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MedvedevDP.Sprint6.Task6.V10.Lib
{
    public class DataService : ISprint6Task6V10
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден: " + path);

            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new char[] { ' ', '\t', '\r', '\n', ',', '.', ';', ':', '!', '?', '-', '(', ')', '[', ']', '"' },
                StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (word.Contains('w') && !word.Contains('W'))
                {
                    result.Append(word + " ");
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}