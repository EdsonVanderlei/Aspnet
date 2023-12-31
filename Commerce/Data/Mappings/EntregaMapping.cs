﻿using Commerce.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Commerce.Data.Mappings
{
    public class EntregaMapping : IEntityTypeConfiguration<Entrega>
    {
        public void Configure(EntityTypeBuilder<Entrega> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PrazoDias).IsRequired().HasColumnType("bigint");
            builder.Property(p => p.ValorFrete).IsRequired().HasColumnType("DECIMAL(11,2)");
            builder.HasOne(p => p.Pedido).WithOne(p => p.Entrega);
            builder.ToTable("Entregas");
        }
    }
}
