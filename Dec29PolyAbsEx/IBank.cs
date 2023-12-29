using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public interface IBank
    {
        bool DepositAmount(double amout);
        bool WithDrawAmount(double amount); double CheckBal();
    }
    public class SavingsAccount : IBank
    {
        private double balance = 0;
        private readonly double perdayWithDrawLimit = 10000;
        private double TodaysWithDrawAmount = 0;
        public double CheckBal() { return balance; }
        public bool DepositAmount(double amout)
        {
            balance = balance + amout;
            //   Console.WriteLine(" you deposited  amount"+amout);
            Console.WriteLine("your balance after deposit " + balance);
            return true;
        }
        public bool WithDrawAmount(double amount)
        {
            if (balance < amount) { Console.WriteLine("have amount  less than  amout "); return false; }
            else if (TodaysWithDrawAmount + amount > perdayWithDrawLimit) { Console.WriteLine("withdraw attempt failed becuae per day we can withdraw only 10000"); return false; }
            else { balance = balance - amount; TodaysWithDrawAmount = TodaysWithDrawAmount + amount; Console.WriteLine(" Balnce  in acc is " + balance); return true; }
        }
    }
    public class CurrentAccount : IBank
    {
        private double Balance = 0;
        public double CheckBal() { return Balance; }

        public bool DepositAmount(double amout)
        {
            Balance = Balance + amout;
            Console.WriteLine(" you have amount of ", Balance);
            return true;
        }
        public bool WithDrawAmount(double amount)
        {
            if (Balance < amount) { Console.WriteLine("insuffiecient funds"); return false; }
            else { Balance = Balance - amount; Console.WriteLine("curremnt account balance is " + Balance); return true; }
        }
    }
    class Testbank
    {
        static void Main(string[] args)
        {
            IBank b1 = new SavingsAccount(); b1.DepositAmount(20000); b1.WithDrawAmount(5000);
            double bal = b1.CheckBal();
            Console.WriteLine(" after deposit and withdraw " + bal);
            IBank b2 = new CurrentAccount(); b2.DepositAmount(4500); b2.WithDrawAmount(3000); double a = b2.CheckBal();
        }
    }
}

