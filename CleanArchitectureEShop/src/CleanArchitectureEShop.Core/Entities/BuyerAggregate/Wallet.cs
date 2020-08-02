using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CleanArchitectureEShop.Core.Entities.BuyerAggregate
{
    public class Wallet
    {
        public decimal Balance { get; private set; }

        public Wallet(decimal balance)
        {
            Guard.Against.Negative(balance, nameof(balance));

            Balance = balance;
        }

        public void AddMoney(decimal amount)
        {
            Guard.Against.NegativeOrZero(amount, nameof(amount));

            Balance += amount;
        }


        public void ExtractMoney(decimal amount)
        {
            Guard.Against.NegativeOrZero(amount, nameof(amount));

            if (Balance - amount < 0)
            {
                throw new ArgumentException("Balance will get negative");
            }

            Balance -= amount;
        }
    }
}
