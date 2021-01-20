using FluentAssertions;
using Homework.Domain.Services;
using Xunit;

namespace BankAppTests
{
    public class AccountServiceTests
    {
        [Fact]
        public void TestIsValueNegative()
        {
            //Arrange
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
            //Arrange
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
            //Arrange
            var accountService = new AccountService();
            string input = "4";

            //Act
            decimal output = accountService.ParseTopupInputValue(input);

            //Assert
            output.Should().Be(4);
        }

        [Fact]
        public void TestTryParseTopupInputValue()
        {
            //Arrange
            var accountService = new AccountService();
            string input = "8";

            //Act
            bool result = accountService.TryParseTopupInputValue(input);

            //Assert
            result.Should().BeTrue();
        }
    }
}
