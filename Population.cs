using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int i = 0;
            int a = initialPopulation;
            while (a <= currentPopulation)
            {
                double v = a * percent / 100;
                int t = Convert.ToInt32(v);
                a += t + visitors;
                i++;
            }
            return i;
        }
    }
}