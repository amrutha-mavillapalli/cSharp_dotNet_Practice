namespace MyPractise
{
    public class ClsDeadlock
    {
        public class Account
        {
            double _balance; int _id;
            public Account(int id, double balance)
            {
                this._id = id;
                this._balance = balance;
            }
            public int Id { get { return _id; } }
            public void Withdraw(double amount) { _balance -= amount; }
            public void Deposit(double amount) { _balance += amount; }
        }
        public class AccountManager
        {
            Account _fromAccount; Account _toAccount; double _amountToTransfer;
            public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
            {
                this._fromAccount = fromAccount;
                this._toAccount = toAccount;
                this._amountToTransfer = amountToTransfer;
            }
            public void Transfer()
            {
                Console.WriteLine("{0} is trying to lock on {1}", Thread.CurrentThread.Name, _fromAccount.Id);
                lock (_fromAccount)
                {
                    Console.WriteLine("{0} locked on {1}", Thread.CurrentThread.Name, _fromAccount.Id);
                    Console.WriteLine("{0} suspended for 1s", Thread.CurrentThread.Name);
                    // Simulate some work with Thread.Sleep
                    Thread.Sleep(100);
                    Console.WriteLine("{0} back in action and trying to lock on {1}", Thread.CurrentThread.Name, _toAccount.Id);
                    lock (_toAccount)
                    {
                        _fromAccount.Withdraw(_amountToTransfer);
                        _toAccount.Deposit(_amountToTransfer);
                    }
                }
            }
        }
        public static void DeadlockExample()
        {
            Console.WriteLine("Starting Deadlock Example");
            Account A1 = new Account(101, 5000);
            Account A2 = new Account(102, 3000);
            AccountManager AM1 = new AccountManager(A1, A2, 1000);
            Thread T1 = new Thread(new ThreadStart(AM1.Transfer));
            T1.Name = "T1";

            AccountManager AM2 = new AccountManager(A2, A1, 2000);
            Thread T2 = new Thread(new ThreadStart(AM2.Transfer));
            T2.Name = "T2";
            
            T1.Start();
            T2.Start();
            T1.Join();
            T2.Join();
            Console.WriteLine("Transfer completed");
        }
    }
}