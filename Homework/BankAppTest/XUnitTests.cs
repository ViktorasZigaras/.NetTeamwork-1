using FluentAssertions;
using Homework.WebApp.Services;
using Xunit;

namespace BankAppTest
{
    public class XUnitTests
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
    }
}
