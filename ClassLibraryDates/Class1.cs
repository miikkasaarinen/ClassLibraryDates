using System;

namespace ClassLibraryDates
{
    public class Class1
    {

        static void studiesOnTimeOrNot(DateTime startLearningDate, double estimatedTimeToMaster)
        {

            if ((DateTime.Today - startLearningDate).Days > estimatedTimeToMaster)
            {
                Console.WriteLine("Your studies are late");
            }

            else
            {
                Console.WriteLine("Your studies are on time");
            }

        }



        public static void FuturePast()
        {
            bool futureOrPast;

            if (startLearningDate > DateTime.Now)
                futureOrPast = true;
            else
                futureOrPast = false;
        }

    }
}

