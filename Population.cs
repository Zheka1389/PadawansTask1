using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            // put your code here
            //throw new NotImplementedException();
            int population = 0, years = 0;
            do
            {
                population = initialPopulation + (int)(initialPopulation * percent / 100) + visitors;
                initialPopulation = population;
                years++;
            } while (population <= currentPopulation);
            return years;
        }
    }
}