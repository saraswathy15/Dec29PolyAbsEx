using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec29PolyAbsEx
{
    public interface ISavingsAccount { void PrintAmountData(); }
    public interface ICurrentAccount { void PrintAmountData(); }
    public class Account : ISavingsAccount, ICurrentAccount
    {
        static void Main(string[] args)
        {
            ISavingsAccount sa = new Account(); sa.PrintAmountData();
            ICurrentAccount cs = new Account(); cs.PrintAmountData();
        }
        void ICurrentAccount.PrintAmountData() { Console.WriteLine("current acc interface print data method"); }
        void ISavingsAccount.PrintAmountData()
        {
            Console.WriteLine("savings acc interface print data method");
        }
    }
}
