using System.Text;
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
        private double CalculateFunction(double x)
        {
            if (Math.Abs(2 * x - 2) < 1e-9) 
            {
                return 0; 
            }

            double result = 4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2);
            return Math.Round(result, 2);
        }
    }
}
