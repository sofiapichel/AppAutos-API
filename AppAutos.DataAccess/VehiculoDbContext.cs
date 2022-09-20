using AppAutos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAutos.DataAccess
{
    public class VehiculoDbContext : DbContext
    {
        public VehiculoDbContext(DbContextOptions<VehiculoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating( ModelBuilder builder )
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //    //optionsBuilder.UseSqlServer(@"Data Source = localhost; Initial Catalog = SMSAsignaciones; Integrated Security = true");
            //optionsBuilder.UseSqlServer(@"Server=.\sqlexpress;Database=Api_Motorium; Trusted_Connection=true;");
        //    //comentar OnConfiguring  cuando  se configure en BASE del constructor
        //    //Solo usar alguna linea de acá, cuando se realicen migraciones
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Color> Colores { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }
}