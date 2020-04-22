

namespace DownUpCasting.Entities.Class
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance(double pct)
        {
            Balance = Balance + Balance * pct;
        }

        public override void Withdraw(double amount)
        {
            //Balance = (double)Balance - amount;
            base.Withdraw(amount);
            Balance -= 15;
        }
    }
}
