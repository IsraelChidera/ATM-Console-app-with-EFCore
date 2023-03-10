namespace ATM.BLL
{
    public class AtmOperations
    {
        private int _balance = 100000;
        public int _amt;
        public async Task RunWithdraw()
        {


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===========================================================");
            Console.WriteLine($"Your current balance is ${_balance - _amt}");
            Console.WriteLine("===========================================================\n");
            Console.ResetColor();

            while (true)
            {

            Start: Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Withdrawal must be more than $100");
                Console.ResetColor();

                Console.Write("Enter amount to withdraw: ");
                string input = Console.ReadLine();
                int withdrawAmount;

                if (!int.TryParse(input, out withdrawAmount))
                {
                    Console.Clear();
                    Utility.ErrorPrompts("Invalid amount. Please try again.");
                    //Console.WriteLine("\nInvalid amount. Please try again.\n");
                    goto Start;
                }

                if (withdrawAmount > _balance)
                {
                    Console.Clear();
                    Utility.ErrorPrompts("Insufficient funds.");
                    //Console.WriteLine("Insufficient funds.");
                    goto Start;
                }

                if (int.TryParse(input, out withdrawAmount) && withdrawAmount > 99)
                {
                    Console.Clear();
                    _balance -= withdrawAmount;

                    //Console.WriteLine($"\nSuccessfully withdrew ${withdrawAmount}.\nYour new balance is ${balance}.\n");

                    //int amount = withdrawAmount;

                    /*using (IOperations withdraw = new OperationService(new AtmDbConnection()))
                    {
                        await withdraw.CreateWithdrawTable();
                        using (IOperations operationsSeedData = new OperationService(new AtmDbConnection()))
                        {                            
                            await operationsSeedData.InsertWithdrawData();
                        }

                        WithdrawViewModel userWithdraw = new WithdrawViewModel
                        {
                            Balance = _balance,
                            AmountWithdrawn = withdrawAmount,
                        };

                        await withdraw.Withdraw(userWithdraw);
                    }*/
                    Utility.SucessfullTransferPrompts($"\nSuccessfully withdrew ${withdrawAmount}.\nYour new balance is ${_balance}.\n");
                }
                else
                {
                    Console.Clear();
                    Utility.ErrorPrompts("Amount must be greater than $100");
                    //Console.WriteLine("Amount must be greater than $100");
                    goto Start;
                }

            Begin: Console.Write("Do you want to perform another transaction? (y/n): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "y":
                        //Console.WriteLine();
                        goto Start;

                    case "n":
                        Console.WriteLine("Thank you for banking with us");
                        return;
                    default:
                        Console.WriteLine("Error");
                        goto Begin;
                }

            }


        }

        public async Task RunDeposit()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n================================================================");
            Console.WriteLine($"DEPOSIT");
            Console.WriteLine("=================================================================\n");
            Console.ResetColor();

            while (true)
            {
            Start: Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Amount to be deposited must be more than $50");
                Console.ResetColor();

                Console.WriteLine("How much do you want to deposit?");
                Console.Write("$ ");
                string amount = Console.ReadLine();


                if (!int.TryParse(amount, out _amt) || _amt < 50)
                {
                    Console.Clear();
                    Utility.ErrorPrompts("Invalid amount. Please try again.");
                    //Console.WriteLine("\nInvalid amount. Please try again.\n");
                    goto Start;
                }


            Description: Console.WriteLine("\nWrite a short description here ...");
                string description = Console.ReadLine();


                if (description.Length < 5)
                {
                    Console.Clear();
                    Utility.ErrorPrompts("Description length must be longer than 5");
                    //Console.WriteLine("Description length must be longer than 5");
                    goto Description;
                }

                if (description.Length > 5 && int.TryParse(amount, out _amt))
                {
                    /*using (IOperations deposit = new OperationService(new AtmDbConnection()))
                    {
                        await deposit.CreateDepositTable();
                        using (IOperations operationsSeedData = new OperationService(new AtmDbConnection()))
                        {                            
                            await operationsSeedData.InsertDepositData();                            
                        }
                        DepositViewModel userDeposit = new DepositViewModel
                        {
                            DepositDescription = description,
                            AmountDeposited = _amt.ToString()
                        };

                        await deposit.Deposit(userDeposit);
                        Utility.SucessfullTransferPrompts($"You have deposited ${amount} successfully\n\n");
                    }*/
                    Utility.SucessfullTransferPrompts($"You have deposited ${amount} successfully\n\n");
                }


                Console.ForegroundColor = ConsoleColor.Yellow;
            Begin: Console.WriteLine("===================================================================");
                Console.Write("Do you want to perform another transaction? (y/n): ");
                Console.ResetColor();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "y":
                        //Console.WriteLine();
                        goto Start;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("Thank you for staying with us");
                        return;
                    default:
                        Console.WriteLine("Error");
                        goto Begin;
                }
            };

        }

        public async Task RunTransfer()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n====================================================");
            Console.WriteLine($"TRANSFER");
            Console.WriteLine("====================================================\n");
            Console.ResetColor();

            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Receiver: Console.WriteLine("\nPlease enter the recipient's account number ");
                    Console.WriteLine("The length of the account number must exceed 5");
                    Console.ResetColor();

                    string receiverAccountNumber = Console.ReadLine();
                    int accountNumber;

                    if (!int.TryParse(receiverAccountNumber, out accountNumber) || receiverAccountNumber.Length < 6)
                    {
                        Console.Clear();
                        Utility.ErrorPrompts("Invalid input.\nPlease enter a valid input . . . ");
                        goto Receiver;
                    }


                Amount: Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You can only transfer funds higher than $50");
                    Console.Write("\nPlease enter the amount you wish to transfer: $");
                    Console.ResetColor();

                    string transferAmount = Console.ReadLine();
                    int Amount;

                    if (!int.TryParse(transferAmount, out Amount) || Amount < 50)
                    {
                        Console.Clear();
                        Utility.ErrorPrompts("Invalid input.\nPlease enter a valid  ");
                        goto Amount;
                    }

                Desc: Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Please enter the recipient's name: ");
                    Console.ResetColor();
                    string descriptions = Console.ReadLine();
                    if (descriptions.Length < 3)
                    {
                        Console.Clear();
                        Utility.ErrorPrompts("Invalid input.\nInput length must be greater than 3 ");
                        goto Desc;
                    }

                    if (Amount > _balance)
                    {
                        throw new Exception("\nInsufficient funds.");
                    }

                    if (int.TryParse(transferAmount, out Amount) && Amount > 50)
                    {
                        _balance -= Amount;

                        Utility.SucessfullTransferPrompts("Transfer successful.");
                        Console.WriteLine("Your new balance is ${0}.", _balance);

                        string Account = receiverAccountNumber;
                        string amount = _balance.ToString();
                        string description = descriptions;
                        DateTime dateTime = DateTime.Now;

                        /*using (IOperations transfer = new OperationService(new AtmDbConnection()))
                        {
                            await transfer.CreateTransferTable();
                            using (IOperations operationsSeedData = new OperationService(new AtmDbConnection()))
                            {
                                await operationsSeedData.InsertTransferData();                                
                            }
                            TransferViewModel userTransfer = new TransferViewModel
                            {
                                ReceiverAccount = Account,
                                AmountTransferred = amount,
                                TransferDescription = description,
                                CreatedAt = dateTime
                            };

                            await transfer.Transfer(userTransfer);
                        }*/

                    }
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    /*Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine(ex.TargetSite);
                    Console.WriteLine(ex.Source);*/
                }


            Begin: Console.Write("Do you want to perform another transaction? (y/n): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "y":
                        break;

                    case "n":
                        Console.Clear();
                        Console.WriteLine("Thank you for banking with us");
                        return;
                    default:
                        Console.WriteLine("Error");
                        goto Begin;
                }
            }


        }

        public void RunBalance()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n====================================================");
            Console.Write("Amount in bank: $");
            Console.WriteLine(_balance - _amt);
            Console.WriteLine("====================================================\n");
            Console.ResetColor();

        }

    }
}
