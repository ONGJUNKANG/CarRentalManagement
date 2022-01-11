using CarRentalManagement.Shared.domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
              new Model
              {
                  Id = 1,
                  Name = "BMW"
              },
              new Model
              {
                  Id = 2,
                  Name = "Toyota"
              }
              );
        }
    }
}
