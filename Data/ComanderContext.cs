using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class ComanderContext : DbContext
    {
        public ComanderContext(DbContextOptions<ComanderContext> opt):base(opt)
        {
            
        }

        public DbSet<Command> Commands { get; set; }
        
    }
}