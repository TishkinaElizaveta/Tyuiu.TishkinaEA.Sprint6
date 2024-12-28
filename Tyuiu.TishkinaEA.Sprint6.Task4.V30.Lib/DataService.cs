using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task4.V30.Lib
{
    public class DataService : ISprint6Task4V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            if (startValue > stopValue)
                throw new ArgumentException("startValue должен быть меньше или равен stopValue");

            // Генерируем значения диапазона с шагом 1
            int rangeSize = stopValue - startValue + 1;
            double[] results = new double[rangeSize];

            for (int i = 0; i < rangeSize; i++)
            {
                int x = startValue + i;
                double denominator = Math.Sin(x) + 2;

                // Проверка деления на ноль
                double fraction = denominator != 0 ? (5 * x + 2.5) / denominator : 0;

                // Вычисление функции
                double result = fraction + 2 * x + 2;

                // Округляем до двух знаков
                results[i] = Math.Round(result, 2);
            }

            return results;
        }
    }
}
