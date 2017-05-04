using EFTest.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFTest.Data
{
    public class InstrucaoPagamentoMap : EntityTypeConfiguration<InstrucaoPagamento>
    {
        public InstrucaoPagamentoMap() : base()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            ToTable("InstrucaoPagamento");

            Property(p => p.Descricao)
                .HasColumnName("DS_Descricao")
                .IsRequired()
                .HasMaxLength(80);

            Property(p => p.Valor)
                .HasColumnName("VL_Valor")
                .IsRequired();

            HasOptional(p => p.ArquivoPagamentoEntidade)
                .WithRequired(p => p.InstrucaoPagamento);
        }
    }
}
