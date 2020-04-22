
namespace DownUpCasting.Entities.Class
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance = (double)Balance - amount - 5.00;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
