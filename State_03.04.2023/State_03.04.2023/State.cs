using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace StateNS
{
    public abstract class State
    {
        Account account;
        double balance;
        double interest;
        double lowerLimit;
        double upperLimit;

        public Account GetAccount()
        {
            return account;
        }
        public void SetAccount(Account account)
        {
            this.account = account;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public abstract void Deposit(double amount);
	public abstract bool Withdraw(double amount);
	public abstract bool PayInterest();
    }
}
