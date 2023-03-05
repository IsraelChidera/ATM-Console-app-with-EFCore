using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DAL.Models.Configuration
{
    public class DepositConfiguration : IEntityTypeConfiguration<DepositViewModel>
    {
        public void Configure(EntityTypeBuilder<DepositViewModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AmountDeposited);
        }
    }
}
