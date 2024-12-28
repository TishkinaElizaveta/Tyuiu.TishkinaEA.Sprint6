using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task6.V7.Lib
{
    public class DataService : ISprint6Task6V7
    {
        public string CollectTextFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            string[] lines = File.ReadAllLines(path);
            string result = string.Empty;

            foreach (string line in lines)
            {
                string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length >= 3)
                {
                    result += words[2] + " "; // Добавляем третье слово и пробел
                }
            }

            return result.Trim(); // Убираем лишние пробелы в конце
        }
    }
}
