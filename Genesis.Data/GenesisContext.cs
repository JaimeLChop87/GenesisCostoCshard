using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


using Core.Entities;
using System.Diagnostics.Contracts;

namespace Genesis.Data
{
    internal class GenesisContext : DbContext
    {
        public DbSet<Agrupador> Agrupadores { get; set; }
        public DbSet<ImpuestosTaxes> ImpuestosTaxes { get; set; }
        public DbSet<ItemActividad> ItemActividades { get; set; }
        public DbSet<MaestroPpto> MaestroPptos { get; set; }
        public DbSet<RecursoUnitario> RecursoUnitarios { get; set; }
        public DbSet<TipoCosto> TiposCosto { get; set; }
        public DbSet<TipoRecurso> TiposRecurso { get; set; }
        public DbSet<UnidadMedida> UnidadesMedida { get; set; }
        public DbSet<Usuarios> Users { get; set; }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite("Data Source=GenesisApp.db");
        }
    }
}
