using Microsoft.EntityFrameworkCore;
namespace ProyectoFinal;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Inventario> Inventario { get; set; }
}