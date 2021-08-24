using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExam
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount chk1 = new CheckingAccount();
            chk1.AccountNo = "487598";
            chk1.CustomerName = "Jamil";
            chk1.ServiceCharge = 900;

            BankAccount b1 = chk1;  // Upcasting (subclass fields and methods will be hiden)

            CheckingAccount chk2 = (CheckingAccount)b1;  // Downcasting (type cast needed)

            double charge = chk2.ServiceCharge;


            // RuntimePolymorphism

            BankAccount b = new BankAccount();  // error since abstract class
            CheckingAccount ch = new CheckingAccount();
            SavingAccount sv = new SavingAccount();

            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(b);
            bankAccounts.Add(ch);
            bankAccounts.Add(sv);

            foreach(BankAccount account in bankAccounts)
            {
                account.Withdraw(300);  
            }
        }
    }
}
