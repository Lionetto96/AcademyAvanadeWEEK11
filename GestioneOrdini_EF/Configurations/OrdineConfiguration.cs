using GestioneOrdini_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestioneOrdini_EF
{
    public class OrdineConfiguration : IEntityTypeConfiguration<Ordine>
    {
        public void Configure(EntityTypeBuilder<Ordine> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.CodiceOrdine).IsRequired();
            builder.Property(o => o.CodiceProdotto).IsRequired();
            builder.Property(o => o.DataOrdine).IsRequired();
            builder.Property(o => o.Importo).HasColumnType("decimal(18,2)").IsRequired();

            //relazione 1:n  Cliente:Ordine
            //builder.HasOne(x => x.Cliente).WithMany(x => x.Ordini).HasForeignKey(x => x.IdCliente);
        }
    }
}