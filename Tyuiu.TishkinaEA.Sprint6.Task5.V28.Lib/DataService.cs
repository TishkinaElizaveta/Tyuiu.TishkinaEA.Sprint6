using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден", path);

            List<double> values = new List<double>();

            // Читаем строки из файла
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                // Разбиваем строку на элементы, предполагая, что числа разделены пробелами
                string[] elements = line.Split(new[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string element in elements)
                {
                    if (double.TryParse(element, out double number))
                    {
                        // Округляем до трех знаков после запятой и добавляем в список
                        values.Add(Math.Round(number, 3));
                    }
                }
            }

            return values.ToArray();
        }

        /// <summary>
        /// Метод фильтрует числа, меньшие 10, из массива.
        /// </summary>
        /// <param name="data">Массив чисел.</param>
        /// <returns>Массив чисел, меньших 10.</returns>
        public double[] GetNumbersLessThanTen(double[] data)
        {
            return data.Where(x => x < 10).ToArray();
        }
    }
}
