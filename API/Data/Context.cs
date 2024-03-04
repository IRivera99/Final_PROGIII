using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class Context : DbContext
{
    public DbSet<Configuracion> Configuracion { get; set; }
    public Context(DbContextOptions options) :base(options){}   
}
