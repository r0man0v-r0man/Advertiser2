using Infrastructure.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistance.Configurations
{
    public class FlatConfiguration : IEntityTypeConfiguration<Flat>
    {
        public void Configure(EntityTypeBuilder<Flat> builder)
        {
            builder
                .Property(property => property.Description)
                .IsRequired();
            builder
                .Property(property => property.Price)
                .IsRequired();
            builder
                .Property(property => property.IsActive)
                .IsRequired();
            builder
                .Property(property => property.Rooms)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
