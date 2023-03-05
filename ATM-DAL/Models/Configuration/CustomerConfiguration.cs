using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DAL.Models.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerViewModel>
    {
        public void Configure(EntityTypeBuilder<CustomerViewModel> builder)
        {
            builder.Property(e => e.CardNumber)
                .IsRequired()
                .HasMaxLength(8);

            builder.Property(e => e.Pin)
                .IsRequired()
                .HasMaxLength(4);

            builder.HasIndex(e => e.CardNumber, "IX_Customer_Card_Number");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.TimeStamp)
            .IsRowVersion()
            .IsConcurrencyToken();
        }
    }
}
