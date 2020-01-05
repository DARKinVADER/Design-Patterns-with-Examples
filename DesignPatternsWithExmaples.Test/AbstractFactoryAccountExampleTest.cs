using Xunit;
using DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample;

namespace DesignPatternsWithExamples.Test
{
    public class AbstractFactoryAccountExampleTest
    {
        [Fact]
        public void GetCreditUnionFactory_CitiType_ReturnsCitiCreditUnionFactory()
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.Citi);

            Assert.IsType<CitiCreditUnionFactory>(abstractFactory);
        }

        [Fact]
        public void GetCreditUnionFactory_NationalType_ReturnsNationalCreditUnionFactory()
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.National);

            Assert.IsType<NationalCreditUnionFactory>(abstractFactory);
        }

        [Fact]
        public void CitiSavingsAccount_Balance_Returns1000()
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.Citi);

            ISavingsAccount savingsAccount = abstractFactory.CreateSavingsAccount();

            Assert.Equal(1000, savingsAccount.Balance);
        }

        [Fact]
        public void CitiLoanAccount_InterestRate_Returns7()
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.Citi);

            ILoanAccount loanAccount = abstractFactory.CreateLoanAccount();

            Assert.Equal(7, loanAccount.InterestRate);
        }
        [Fact]
        public void NationalSavingsAccount_Balance_Returns2000()
        {
            ICreditUnionFactory abstractFactory =
                CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.National);

            ISavingsAccount savingsAccount = abstractFactory.CreateSavingsAccount();

            Assert.Equal(2000, savingsAccount.Balance);
        }

        [Fact]
        public void NationalLoanAccount_InterestRate_Returns10()
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(AccountType.National);

            ILoanAccount loanAccount = abstractFactory.CreateLoanAccount();

            Assert.Equal(10, loanAccount.InterestRate);
        }

        [Theory]
        [InlineData(AccountType.Citi, 1000, 7)]
        [InlineData(AccountType.National, 2000, 10)]
        public void CheckAllAccounts_ReturnsCorrectBalanceAndInterestRate(AccountType accountType, int balance, int interestRate)
        {
            ICreditUnionFactory abstractFactory = CreditUnionFactoryProvider.GetCreditUnionFactory(accountType);

            ISavingsAccount savingsAccount = abstractFactory.CreateSavingsAccount();
            ILoanAccount loanAccount = abstractFactory.CreateLoanAccount();

            Assert.Equal(balance, savingsAccount.Balance);
            Assert.Equal(interestRate, loanAccount.InterestRate);
        }
    }
}
