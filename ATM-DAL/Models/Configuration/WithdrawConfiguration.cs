using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DAL.Models.Configuration
{
    public class WithdrawConfiguration : IEntityTypeConfiguration<WithdrawViewModel>
    {
        public void Configure(EntityTypeBuilder<WithdrawViewModel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AmountWithdrawn);
        }
    }
}
