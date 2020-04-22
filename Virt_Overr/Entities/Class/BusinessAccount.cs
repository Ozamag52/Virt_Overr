using System;

namespace DownUpCasting.Entities.Class
{
    class BusinessAccount : Account
    {
        public double Limit { get; set; }

        public BusinessAccount()
        {

        }
        public BusinessAccount(int number, string holder, double balance, double limit) : base(number, holder, balance)
        {
            Limit = limit;
        }

        public void Loan(double amount)
        {
            if (amount <= Limit)
            {
                Balance = +amount;
            }
            else
            {
                Console.WriteLine("Valor requerido de emprestimo acima do limite permitido de :" + Limit);
            }

        }

        public override void Withdraw(double amount)
        {
            //Balance = (double)Balance - amount - 10.00;
            base.Withdraw(amount);
            Balance -= 10.00;
        }
    }

}
