using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {

            var task = new List<string>();
            Console.WriteLine("Checking Survey Details");
            double surveyed, unsurveyed;
            surveyed = Q1Results.NumberSurveyed;
            unsurveyed = surveyed - Q1Results.NumberResponded;
            Console.WriteLine(unsurveyed);
            Console.WriteLine(surveyed);


            //Logical Operation

            if(unsurveyed> surveyed)
            {
                Console.WriteLine("More Number Of People Not Responded");
            }
            else
            {
                Console.WriteLine("More Number Of People Responded");
            }

            //
            if (Q1Results.FavoriteProduct == "Cappucino")
            {
                Console.WriteLine("Yes It is the Favourite Product");
            }
            else
            {
                Console.WriteLine("No it is not Favourite Product");
            }

            if (true)
            {
                task.Add("Task is added");
                Console.WriteLine("It is Evaluated as True and task is added");
            }

            foreach (var item in task)
            {
                Console.WriteLine(item);
            }
        }
    }
}
