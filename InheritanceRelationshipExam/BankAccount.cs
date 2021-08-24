using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExam
{
    abstract class BankAccount
    {
        public string AccountNo { set; get; }
        public string CustomerName { set; get; }
        public double Balance { set; get; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public virtual string Withdraw(double amount) // Overriding
        {
            Balance -= amount;
            return "Withdrawn";
        }
        public abstract void Transfer(string from, string to, double amount);
    }
}
