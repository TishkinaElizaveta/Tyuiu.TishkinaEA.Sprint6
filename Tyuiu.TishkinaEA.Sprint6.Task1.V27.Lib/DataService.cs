using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task1.V27.Lib
{
    public class DataService : ISprint6Task1V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int step = 1;
            int size = (stopValue - startValue) / step + 1;
            double[] results = new double[size];

            for (int i = 0; i < size; i++)
            {
                int x = startValue + i * step;
                results[i] = CalculateFunction(x);
            }

            return results;
        }
    }
}
