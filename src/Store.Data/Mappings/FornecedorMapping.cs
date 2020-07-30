using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            // PK
            builder.HasKey(f => f.Id);

            // Columns
            builder.Property(f => f.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(f => f.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            // Relationship
            // 1 : 1 => Fornecedor : Endereco
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);

            // 1 : N => Fornecedor : Produtos
            builder.HasMany(f => f.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
                
        }
    }
}
