using EFTest.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFTest.Data
{
    public class BoletoMap : EntityTypeConfiguration<Boleto>
    {
        public BoletoMap() : base()
        {
            HasKey(p => p.InstrucaoPagamentoId);

            Property(p => p.InstrucaoPagamentoId)
                .HasColumnName("InstrucaoPagamentoId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            ToTable("Boleto");

            Property(p => p.CodigoBarras)
                .HasColumnName("CD_Barras")
                .HasMaxLength(44)
                .IsOptional();

            Property(p => p.DataVencimento)
                .HasColumnName("DT_Vencimento")
                .IsOptional();

            HasRequired(p => p.InstrucaoPagamentoEntidade)
                .WithOptional();              
        }
    }
}
