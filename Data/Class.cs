using CarWorkshop;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_Postgresql.Models
{
    public class UsersdbContext : DbContext
    {
        public UsersdbContext(DbContextOptions<UsersdbContext> options)
            : base(options)
        {


        }
        public virtual DbSet<User> User { get; set; }
    }
}
