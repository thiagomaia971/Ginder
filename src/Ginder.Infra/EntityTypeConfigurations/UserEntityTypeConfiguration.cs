using System;
using Ginder.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ginder.Infra.EntityTypeConfigurations
{
    public class UserEntityTypeConfiguration : EntityTypeConfigurationBase<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User (Guid.Parse("C6699C75-5F44-4029-A404-84CE8A3951C8"), Guid.Parse("c8413c17-63e7-491a-9eae-0489737e19ff"), "admin", "123")
            );
        }
    }
}