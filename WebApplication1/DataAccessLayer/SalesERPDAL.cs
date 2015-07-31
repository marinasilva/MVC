using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DataAccessLayer
{
    public class SalesERPDAL : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}