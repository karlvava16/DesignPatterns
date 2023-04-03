﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateNS
{
    public class RedState : State
    {
        void Initialize() { }
        void StateChangeCheck() { }
        public RedState(double balance, Account account) { }
        public RedState(State state) { }
        public override void Deposit(double amount) { }
        public override bool Withdraw(double amount) { return false; }
        public override bool PayInterest()
        { return false; }
    }
}