using CarRentalManagement.Shared.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
            new Make
            {
                Id = 1,
                Name = "3 Series"
            },
            new Make
            {
                Id = 2,
                Name = "X5"
            },
            new Make
            {
                Id = 3,
                Name = "Prius"
            },
            new Make
            {
                Id = 4,
                Name = "Rav4"
            }
            );
            
        }
    }
}
