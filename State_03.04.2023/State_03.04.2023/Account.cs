using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateNS
{
    public class Account
    {
        State state;
        string owner;

	    public Account(string owner)
        {
            this.owner = owner;
        }
        public double GetBalance()
        {
            return state.GetBalance();
        }
        public State GetState()
        {
            return state;
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void Deposit(double amount)
        { this.state.Deposit(amount); }
        public void Withdraw(double amount)
        { 
        }
        public void PayInterest()
        {

        }
    }
}
