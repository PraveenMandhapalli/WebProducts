using Microsoft.EntityFrameworkCore;
using WebProducts.Server.Models;
namespace WebProducts.Server.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Country> Countries { get; set; }   
        public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }  
       
    }
}
