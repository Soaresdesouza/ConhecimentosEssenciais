using AppSemTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace AppSemTemplate.Data
{
    public class AppSemTemplateDbContext : DbContext
    {
        public AppSemTemplateDbContext(DbContextOptions<AppSemTemplateDbContext> opt) : base(opt)
        {
        }
        public DbSet<Produto> Produtos { get; set; }
    }
}
