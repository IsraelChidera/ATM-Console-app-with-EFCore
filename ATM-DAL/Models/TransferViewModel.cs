namespace ATM_DAL.Models
{
    public class TransferViewModel : BaseEntity
    {
        public string ReceiverAccount;

        public string AmountTransferred;

        public string TransferDescription;

        public DateTime CreatedAt;

        public CustomerViewModel Customer { get; set; }
    }
}
