using Datos.BaseDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class FerreteriaContext : DbContext
    {
        public FerreteriaContext():base("name=Ferreteria")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<CategoriaClientes> CategoriaClientes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<GrupoDescuentoCliente> GrupoDescuentoClientes { get; set; }
    }
}
