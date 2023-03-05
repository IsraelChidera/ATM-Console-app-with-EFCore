namespace ATM_DAL.Models
{
    public class DepositViewModel : BaseEntity
    {
        public string AmountDeposited { get; set; }
        public string DepositDescription { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}
