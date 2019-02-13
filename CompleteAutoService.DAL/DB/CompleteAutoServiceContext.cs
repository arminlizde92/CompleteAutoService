using System.Data.Entity;

namespace CompleteAutoService.DAL.DB
{
    /// <summary>
    /// Complete auto service context class
    /// </summary>
    public class CompleteAutoServiceContext : DbContext
    {
        /// <summary>
        /// Entity framework will create a database in your local SQLEXPRESS server with a name {Namespace}.{Context class name}
        /// </summary>
        public CompleteAutoServiceContext() : base() { }

        /// <summary>
        /// The name will be the one passed as parameter in the base constructor on the local SQLEXPRESS database server.
        /// </summary>
        /// <param name="dbName">database name</param>
        public CompleteAutoServiceContext(string dbName) : base(dbName) { }
    }
}
