using ContaDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContaRepository.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
            {

            }
        public DbSet<ContaLuz> ContasLuz {get; set;}
        public DbSet<Imovel> Imoveis {get; set;}  
    }
}