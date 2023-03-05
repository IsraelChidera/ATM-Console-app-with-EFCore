namespace ATM_DAL.Models
{
    public class CustomerViewModel : BaseEntity
    {
        public string CardNumber;
        public string Pin;
        public DateTime LogTime;
        public IEnumerable<WithdrawViewModel> Withdraw = new List<WithdrawViewModel>();
        public IEnumerable<TransferViewModel> Transfer = new List<TransferViewModel>();
        public IEnumerable<DepositViewModel> Deposit = new List<DepositViewModel>();
        
    }
}
