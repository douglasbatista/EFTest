using EFTest.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<InstrucaoPagamento> InstrucoesPagamento { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<ArquivoPagamento> ArquivosPagamento { get; set; }

        public DatabaseContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InstrucaoPagamentoMap());
            modelBuilder.Configurations.Add(new BoletoMap());
            modelBuilder.Configurations.Add(new ArquivoPagamentoMap());

            this.Configuration.LazyLoadingEnabled = false;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
