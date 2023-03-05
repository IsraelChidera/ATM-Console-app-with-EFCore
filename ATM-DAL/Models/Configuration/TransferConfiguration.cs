using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DAL.Models.Configuration
{
    public class TransferConfiguration : IEntityTypeConfiguration<TransferViewModel>
    {
        public void Configure(EntityTypeBuilder<TransferViewModel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.AmountTransferred);
        }
    }
}
