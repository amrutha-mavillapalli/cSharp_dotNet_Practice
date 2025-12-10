namespace MyPractise
{
    public class ClsDeadlockResolution
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
                object _lock1, _lock2;
                if (_fromAccount.Id < _toAccount.Id)
                {
                    _lock1 = _fromAccount;
                    _lock2 = _toAccount;
                }
                else
                {
                    _lock1 = _toAccount;
                    _lock2 = _fromAccount;
                }
                Console.WriteLine("{0} is trying to lock on {1}", Thread.CurrentThread.Name, ((Account)_lock1).Id.ToString());
                lock (_lock1)
                {
                    Console.WriteLine("{0} locked on {1}", Thread.CurrentThread.Name, ((Account)_lock1).Id.ToString());
                    Console.WriteLine("{0} suspended for 1s", Thread.CurrentThread.Name);
                    // Simulate some work with Thread.Sleep
                    Thread.Sleep(100);
                    Console.WriteLine("{0} back in action and trying to lock on {1}", Thread.CurrentThread.Name, ((Account)_lock2).Id.ToString());
                    lock (_lock2)
                    {
                        Console.WriteLine("{0} locked on {1}", Thread.CurrentThread.Name, ((Account)_lock2).Id.ToString());
                        _fromAccount.Withdraw(_amountToTransfer);
                        _toAccount.Deposit(_amountToTransfer);
                        Console.WriteLine("{0} transferred {1} from {2} to {3}", Thread.CurrentThread.Name, _amountToTransfer, _fromAccount.Id, _toAccount.Id);
                    }
                }
            }
        }
        public static void DeadlockResolutionExample()
        {
            Console.WriteLine("Starting Deadlock Resolution");
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
             Console.WriteLine("Ending Deadlock Resolution");
        }
    }
}