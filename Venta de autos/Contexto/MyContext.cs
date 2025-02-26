using Microsoft.EntityFrameworkCore;
using Venta_de_autos.Models;

namespace Venta_de_autos.Contexto
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}

