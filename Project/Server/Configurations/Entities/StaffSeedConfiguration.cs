using Microsoft.EntityFrameworkCore;
using Project.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                Id = 1,
                Name = "Bob",
                PhoneNo = "97673095",
                Gender = "Male",
                DepartmentId = 1,
            },

             new Staff
             {
                 Id = 2,
                 Name = "Zayed",
                 PhoneNo = "87692243",
                 Gender = "Female",
                 DepartmentId = 2,
             }
            ); ;
        }
    }
}
