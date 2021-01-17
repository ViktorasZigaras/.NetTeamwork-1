using FluentAssertions;
using Homework.WebApp.Services;
using Xunit;

namespace BankAppTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestIsValueNegative()
        {
            //Arange
            var accountService = new AccountService();
            decimal value = 2.50M;
            //Act
            bool result = accountService.IsValueNegative(value);
            //Assert
            result.Should().BeFalse();
        }
        [Fact]
        public void TestReplaceDot()
        {
            //Arange
            var accountService = new AccountService();
            string input = "2.50";
            //Act
            string output = accountService.ReplaceDot(input);
            //Assert
            output.Should().Be("2,50");
        }
        [Fact]
        public void TestParseTopupInputValue()
        {
            //Arange
            var accountService = new AccountService();
            string input = "4,50";
            //Act
            decimal output = accountService.ParseTopupInputValue(input);
            //Assert
            output.Should().Be(4.50M);
        }
        [Fact]
        public void TestTryParseTopupInputValue()
        {
            //Arange
            var accountService = new AccountService();
            string input = "8,50";
            //Act
            bool result = accountService.TryParseTopupInputValue(input);
            //Assert
            result.Should().BeTrue();
        }

        // Registration functionality test

        //[Fact]
        //public void ValidPassword()
        //{
        //    var passwordValidator = new PasswordValidator();
        //    const string password = "InsertPassword";

        //    bool isvalid = passwordValidator.Isvalid(password);

        //    Assert.True(isvalid, $"The password {password} is not valid");

        //}

        /* [Fact]
         public void Test1()
         {
             var outcome = 2 * 2;

             //Assert.Equal(4, outcome);
             outcome.Should().Be(4);
         }*/

        //[Fact]
        //public void Adding_Funds_Updates_Balance()
        //{
        //    var account = new BankAccount(4000);

        //    account.Add(300);

        //    Assert.Equal(4300, account.Balance);
        //}

        //[Fact]
        //public void Withdrawing_Funds_Updates_Balance()
        //{
        //    var account = new BankAccount(4000);

        //    account.Withdrawing(300);

        //    Assert.Equal(3700, account.Balance);
        //}

        //[Fact]
        //public void Transfering_Funds_Updates_Both_Accounts()
        //{
        //    var account = new BankAccount(4000);
        //    var otherAccount = new BankAccount();

        //    account.TransferFundsTo(1000);

        //    Assert.Equal(1000, account.Balance);
        //    Assert.Equal(1000, otherAccount.Balance);
        //}
    }
}
