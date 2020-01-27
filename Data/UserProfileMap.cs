using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class UserProfileMap
    {
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityBuilder)
        {
            entityBuilder.HasKey(k => k.Id);
            entityBuilder.Property(p => p.FirstName).IsRequired();
            entityBuilder.Property(p => p.LastName).IsRequired();

        }
    }
}
