using System;

namespace ConsoleApp3
{

    /// <summary>
    /// This class is written to learn best practices in unit testing.
    /// </summary>
    class Program
    {

        /// <summary>
        /// Here is the entry point.
        /// </summary>
        /// <param name="args">string[]</param>
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// This method return one state of three: Night, Morning and
        /// Afternoon. String changes with time between Night, Morning and
        /// Afternoon.
        /// </summary>
        /// <returns>A string  which contains Night, Morning or Afternoon.</returns>
        public static string GetTimeOfDay(DateTime time)
        {

            // It depends on time of date if morning, evening or afternoon is
            // returned.
            if (time.Hour >= 0 && time.Hour < 6)
            {
                return "Night";
            }
            if (time.Hour >= 6 && time.Hour < 12)
            {
                return "Morning";
            }
            if (time.Hour >= 12 && time.Hour < 18)
            {
                return "Afternoon";
            }

            return "Evening";
        }
    }
}
