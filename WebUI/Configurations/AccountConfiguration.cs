using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebUI.Core.Entities;

namespace WebUI.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x=> x.AccountNumber).IsRequired();
            builder.Property(x=> x.AccountNumber).HasMaxLength(128);
            builder.Property(x=> x.Balance).IsRequired();
        }
    }
}
