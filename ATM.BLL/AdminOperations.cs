namespace ATM.BLL
{
    public class AdminOperations
    {
        public async Task GetDepositTransactions()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("============================================================");
                Console.WriteLine("\tAll Deposit Transactions");
                Console.WriteLine("============================================================");
                Console.WriteLine("Deposits transactions");
                /*using (IAdminInterface admin = new AtmAdminService(new AtmDbConnection()))
                {
                    await admin.DepositTransactions();
                };*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }
        }

        public async Task GetTransferTransactions()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("============================================================");
                Console.WriteLine("\tAll Transfer Transactions");
                Console.WriteLine("============================================================");
                Console.WriteLine("Transfer transactions");
                /*using (IAdminInterface admin = new AtmAdminService(new AtmDbConnection()))
                {
                    await admin.TransferTransactions();
                };*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }


        }

        public async Task GetWithdrawTransactions()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("===============================================================");
                Console.WriteLine("\tAll Withdraw Transactions");
                Console.WriteLine("===============================================================");
                Console.WriteLine("Withdraw transactions");
                /*using (IAdminInterface admin = new AtmAdminService(new AtmDbConnection()))
                {
                    await admin.WithdrawTransactions();
                };*/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
            }


        }

        public async Task GetAllTransactions()
        {
            try
            {
                Console.WriteLine("All transactions");
                /*using (IAdminInterface admin = new AtmAdminService(new AtmDbConnection()))
                {
                    await admin.ViewAllTransactions();
                }*/
            }
            catch
            {
                Utility.ErrorPrompts("Error. Unable to fetch all transactions");
            }
        }


    }
}


