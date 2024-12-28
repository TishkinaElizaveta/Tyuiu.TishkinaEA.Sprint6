using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
        public class MatrixCsvProcessor
        {
            /// <summary>
            /// Загружает матрицу из CSV файла и возвращает ее в виде двумерного массива.
            /// </summary>
            /// <param name="path">Путь к CSV файлу.</param>
            /// <returns>Двумерный массив целых чисел.</returns>
            public int[,] GetMatrix(string path)
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException("Файл не найден", path);

                string[] lines = File.ReadAllLines(path);
                int rowCount = lines.Length;
                int colCount = lines[0].Split(',').Length;

                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] elements = lines[i].Split(',');

                    for (int j = 0; j < colCount; j++)
                    {
                        if (int.TryParse(elements[j], out int value))
                        {
                            matrix[i, j] = value;
                        }
                        else
                        {
                            throw new FormatException($"Неверный формат данных в строке {i + 1}, столбце {j + 1}.");
                        }
                    }
                }

                return matrix;
            }

            /// <summary>
            /// Изменяет значения в последнем столбце матрицы: числа меньше 2 заменяются на 2.
            /// </summary>
            /// <param name="matrix">Двумерный массив целых чисел.</param>
            /// <returns>Измененная матрица.</returns>
            public int[,] ProcessLastColumn(int[,] matrix)
            {
                int rowCount = matrix.GetLength(0);
                int colCount = matrix.GetLength(1);

                for (int i = 0; i < rowCount; i++)
                {
                    if (matrix[i, colCount - 1] < 2)
                    {
                        matrix[i, colCount - 1] = 2;
                    }
                }

                return matrix;
            }

            /// <summary>
            /// Сохраняет матрицу в CSV файл.
            /// </summary>
            /// <param name="matrix">Двумерный массив целых чисел.</param>
            /// <param name="path">Путь к выходному CSV файлу.</param>
            public void SaveMatrixToCsv(int[,] matrix, string path)
            {
                int rowCount = matrix.GetLength(0);
                int colCount = matrix.GetLength(1);

                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < rowCount; i++)
                    {
                        string[] row = new string[colCount];

                        for (int j = 0; j < colCount; j++)
                        {
                            row[j] = matrix[i, j].ToString();
                        }

                        writer.WriteLine(string.Join(",", row));
                    }
    }
}
