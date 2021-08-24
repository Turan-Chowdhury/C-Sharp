using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRelationshipExam
{
    class SavingAccount : BankAccount
    {
        public double InterestAmount { set; get; }
        public override string Withdraw(double amount) // Overriding
        {
            if(Balance-amount >= 0)
            {
                return base.Withdraw(amount);
            }
            else
            {
                return "Insufficient Balance";
            }
        }
        public override void Transfer(string from, string to, double amount)
        {
            // todo
        }
    }
}
