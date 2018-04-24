using System.Data.Entity;
using Test.Models;

namespace Test.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") {

        }

        
    }
}