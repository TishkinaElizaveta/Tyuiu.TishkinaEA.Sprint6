using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("startValue должен быть меньше или равен stopValue");

            // Генерируем значения диапазона с шагом 1
            int[] range = Enumerable.Range(startValue, stopValue - startValue + 1).ToArray();

            // Вычисляем значения функции для каждого x в диапазоне
            double[] results = new double[range.Length];

            for (int i = 0; i < range.Length; i++)
            {
                int x = range[i];

                // Проверяем деление на ноль
                double denominator = 3.0;
                double divisionResult = (denominator == 0) ? 0 : (2.0 * x / denominator);

                // Вычисляем значение функции
                double result = Math.Sin(x) + divisionResult - Math.Cos(x) * 4 * x;

                // Округляем до двух знаков
                results[i] = Math.Round(result, 2);
            }

            return results;
        }
    }
}
