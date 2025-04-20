
using FinanzasApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanzasApp.Context
{


    public class FinanzasAppContext : DbContext
    {
        public FinanzasAppContext(DbContextOptions<FinanzasAppContext> options)
            : base(options) {}

      public   DbSet<Gastos> Gastos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-USH308DG;Initial Catalog=finanzasApp_data;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");
            }
        }
    }
}