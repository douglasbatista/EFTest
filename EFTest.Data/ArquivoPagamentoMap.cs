using EFTest.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFTest.Data
{
    public class ArquivoPagamentoMap : EntityTypeConfiguration<ArquivoPagamento>
    {
        public ArquivoPagamentoMap() : base()
        {
            HasKey(p => p.InstrucaoPagamentoId);

            Property(p => p.InstrucaoPagamentoId)
                .HasColumnName("InstrucaoPagamentoId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            ToTable("ArquivoPagamento");

            Property(p => p.Conteudo)
                .HasColumnName("DS_Conteudo")
                .IsRequired();
        }
    }
}
