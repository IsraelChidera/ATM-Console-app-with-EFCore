using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_DAL.Models.ViewModels.Configuration
{
    public class TransactionViewModelConfiguration : IEntityTypeConfiguration<TransactionViewModel>
    {
        public void Configure(EntityTypeBuilder<TransactionViewModel> builder)
        {
            
        }
    }
}
