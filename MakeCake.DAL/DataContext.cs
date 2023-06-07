using MakeCake.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeCake.DAL
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<TierDto> Tiers { get; set; }
        public DbSet<BiscuitDto> Biscuits { get; set; }
        public DbSet<FillingDto> Fillings { get; set; }
        public DbSet<CreamDto> Creams { get; set; }
    }
}
