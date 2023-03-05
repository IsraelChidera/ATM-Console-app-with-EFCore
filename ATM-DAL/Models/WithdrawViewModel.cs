namespace ATM_DAL.Models
{
    public class WithdrawViewModel : BaseEntity
    {
        public int Balance { get; set; }
        public int AmountWithdrawn { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
