using System;

namespace SignletonPattern
{
    /// <summary>
    /// Program Class of this Application
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main function of this application where signleton is used.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Call BeginTransaction after creating object of Database class
            Database.Instance.BeginTransaction();

            // Call Insert method but no new instance is created again
            Database.Instance.Insert(new object());

            // Call Update method but no new instance is created again
            Database.Instance.Update(new object());

            // Call EndTransaction but no new instance is created again
            Database.Instance.EndTransaction();

            Console.WriteLine("Press any to exit...");
            Console.ReadKey();
        }
    }
}
