using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            var lines = File.ReadAllLines(path);
            var matrix = new int[lines.Length, lines[0].Split(',').Length];

            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(',').Select(int.Parse).ToArray();
                for (int j = 0; j < values.Length; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            return matrix;
        }

        // Сохранение матрицы в CSV
        public void SaveMatrix(int[,] matrix, string path)
        {
            var lines = new string[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var line = string.Join(",", Enumerable.Range(0, matrix.GetLength(1)).Select(j => matrix[i, j].ToString()));
                lines[i] = line;
            }

            File.WriteAllLines(path, lines);
        }

        // Обработка данных
        public int[,] ProcessMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, matrix.GetLength(1) - 1] < 2)
                {
                    matrix[i, matrix.GetLength(1) - 1] = 2;
                }
            }
            return matrix;
        }

            }
        }
   

