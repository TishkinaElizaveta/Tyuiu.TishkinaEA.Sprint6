using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TishkinaEA.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double denominator = 2 * Math.Pow(x + 5, 2);

            if (Math.Abs(denominator) < 1e-10) 
            {
                return 0;
            }

            double y = Math.Pow(x, 3) / denominator;
            return Math.Round(y, 3); 
        }
        
    }
}
 