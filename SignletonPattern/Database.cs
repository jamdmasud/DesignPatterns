using System;

namespace SignletonPattern
{
    /// <summary>
    /// Database is a sample class to show as an exaple for singletop pattern
    /// I wanna skip code details and showing pattern implatation only.
    /// </summary>
    public class Database
    {
        private static Database _database = null;
        private static object padLock = new object();
        private int instanceCounter = 1;

        /// <summary>
        /// Default constructor should be private for this pattern as we'll not allow to create 
        /// object out site this class.
        /// </summary>
        private Database()
        {
            Console.WriteLine($"Object is created {instanceCounter} time.");
            instanceCounter++;
        }

        /// <summary>
        /// Create the object for database only once by this method
        /// </summary>
        /// <returns></returns>
        public static Database Instance
        {
            get
            {
                // Check if object is not created.
                if (_database == null)
                {
                    // Lock the block so that many objects are not created at same time from different location
                    lock (padLock)
                    {
                        // Check again object is not created while locking the block.
                        if (_database == null)
                        {
                            // Create database object here for application life time.
                            _database = new Database();
                        }
                    }
                }
                return _database;
            }
        }

        /// <summary>
        /// sample method: begin transaction
        /// </summary>
        public void BeginTransaction()
        {
            Console.WriteLine("Transaction started.");
        }

        /// <summary>
        /// sample method: commit or roll back transaction.
        /// </summary>
        public void EndTransaction()
        {
            Console.WriteLine("Transaction completed with rollback/commit.");
        }

        /// <summary>
        /// smple method: Insert enitity into database
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(object entity)
        {
            Console.WriteLine("Data inserted into Database");
        }

        /// <summary>
        /// smple method: Update entity from database
        /// </summary>
        /// <param name="entity"></param>
        public void Update(object entity)
        {
            Console.WriteLine("Data updated into database.");
        }

        /// <summary>
        /// smple method: Delete database
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            Console.WriteLine($"Data deleted containing ID {id}");
        }

        /// <summary>
        /// Get object containing param ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>object</returns>
        public object Get(int id)
        {
            return new {Id = id, Name = "Masud", Address = "Mymensingh", Email = "jamdmasud@gmail.com" };
        }
    }
}
