using Microsoft.EntityFrameworkCore;
using Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class StaffrSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Staff> builder)
        {
            throw new NotImplementedException();
        }
    }
}
