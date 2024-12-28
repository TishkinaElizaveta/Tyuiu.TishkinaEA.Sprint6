using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task3.V30.Lib
{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix.GetLength(0) != 5 || matrix.GetLength(1) != 5)
                throw new ArgumentException("Матрица должна быть размером 5x5.");

            // Итерация по пятой строке (индекс 4)
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[4, j] % 2 == 0) // Проверяем, является ли число четным
                {
                    matrix[4, j] = 0; // Заменяем четное число на 0
                }
            }

            return matrix;
        }
    }
}
