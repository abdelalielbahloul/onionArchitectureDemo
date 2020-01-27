using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class UserMap
    {
        /*
         * this is a configurations and map each user
         */

        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(k => k.Id);
            entityBuilder.Property(p => p.Email).IsRequired();
            entityBuilder.Property(p => p.Password).IsRequired();
            entityBuilder.HasOne(up => up.UserProfile).WithOne(u => u.User).HasForeignKey<UserProfile>(fk => fk.Id);
        }
    }
}
