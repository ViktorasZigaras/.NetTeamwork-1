using FluentAssertions;
using Xunit;

namespace BankApp.UnitTests
{
    public class BankAccountTests
    {
        /* [Fact]
         public void Test1()
         {
             var outcome = 2 * 2;

             //Assert.Equal(4, outcome);
             outcome.Should().Be(4);
         }*/

        [Fact]
        public void Adding_Funds_Updates_Balance()
        {
            var account = new BankAccount(4000);

            account.Add(300);

            Assert.Equal(4300, account.Balance);
        }

        [Fact]
        public void Withdrawing_Funds_Updates_Balance()
        {
            var account = new BankAccount(4000);

            account.Withdrawing(300);

            Assert.Equal(3700, account.Balance);
        }

        [Fact]
        public void Transfering_Funds_Updates_Both_Accounts()
        {
            var account = new BankAccount(4000);
            var otherAccount = new BankAccount();

            account.TransferFundsTo(1000);

            Assert.Equal(1000, account.Balance);
            Assert.Equal(1000, otherAccount.Balance);
        }

    }
}
