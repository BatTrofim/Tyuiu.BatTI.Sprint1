using tyuiu.cources.programming.interfaces.Sprint1;
    
namespace Tyuiu.BatTI.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((Math.Log(x) * y) / (x + (Math.Sqrt(2 * Math.Pow(y, 2)))), 3);
        }
    }
}
