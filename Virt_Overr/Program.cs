using System;
using DownUpCasting.Entities.Class;
namespace DownUpCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc0 = new Account(1001, "Gustavo", 1000);

            BusinessAccount acc1 = new BusinessAccount(1002, "Henrique", 5000, 1000);

            SavingsAccount acc2 = new SavingsAccount(1003, "Maria", 1000, 0.01);

            acc0.Withdraw(10.0);
            acc2.Withdraw(10.0);
            acc1.Withdraw(10.0);
            Console.WriteLine(acc0.Balance);
            Console.WriteLine(acc2.Balance);
            Console.WriteLine(acc1.Balance);



        }
    }
}
