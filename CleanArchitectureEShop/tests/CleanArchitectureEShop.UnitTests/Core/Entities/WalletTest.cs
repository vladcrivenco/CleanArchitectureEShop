using CleanArchitectureEShop.Core.Entities.BuyerAggregate;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitectureEShop.UnitTests.Core.Entities
{

    public class WalletTest
    {
        [Fact]
        public void WalletShouldAddBalance()
        {
            var wallet = new Wallet(100);

            wallet.AddMoney(103);

            Assert.Equal(wallet.Balance, 100 + 103);
        }
    }
}
