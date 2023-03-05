using ATM_DAL.Models;
using ATM_DAL.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ATM_DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<CustomerViewModel> Customer { get; set; }
        public DbSet<WithdrawViewModel> Withdraw { get; set; }
        public DbSet<DepositViewModel> Deposit { get; set; }
        public DbSet<TransferViewModel> Transfer { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerConfiguration().Configure(modelBuilder.Entity<CustomerViewModel>());
            new DepositConfiguration().Configure(modelBuilder.Entity<DepositViewModel>());
            new WithdrawConfiguration().Configure(modelBuilder.Entity<WithdrawViewModel>());
            new TransferConfiguration().Configure(modelBuilder.Entity<TransferViewModel>());
        }

    }
}
