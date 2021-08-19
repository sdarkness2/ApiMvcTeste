using Microsoft.EntityFrameworkCore;
using ApiTestes.Model;

namespace ApiTestes.Data
{
    public class LoljaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public LoljaContext(DbContextOptions<LoljaContext> options) : base(options) { }
    }
}
