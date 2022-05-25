using GestioneOrdini_CORE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestioneOrdini_EF
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CodiceCliente).IsRequired();
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.Cognome).IsRequired();
            //relazione con Ordine
            //builder.HasMany(c => c.Ordini).WithOne(c => c.Cliente).HasForeignKey(c => c.IdCliente);
        }
    }
}