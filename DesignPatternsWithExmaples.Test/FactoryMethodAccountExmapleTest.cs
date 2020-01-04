using System;
using DesignPatternsWithExamples.Creational.FactoryMethod.AccountExmaple;
using Xunit;

namespace DesignPatternsWithExmaples.Test
{
    public class FactoryMethodAccountExmapleTest
    {
        [Fact]
        public void GetSavingsAccount_CitiType_ReturnsCitiSavingsAccount()
        {
            ICreditUnionFactory factory = new SavingsAccountFactory();
            ISavingsAccount citiAccount = factory.GetSavingsAccount(AccountType.Citi);

            Assert.IsType<CitiSavingsAccount>(citiAccount);
        }

        [Fact]
        public void CitiSavingsAccount_Balance_Returns5000()
        {
            // Arrange
            ICreditUnionFactory factory = new SavingsAccountFactory();

            // Act
            ISavingsAccount citiAccount = factory.GetSavingsAccount(AccountType.Citi);

            // Assert
            Assert.Equal(5000, citiAccount.Balance);
        }

        [Fact]
        public void GetSavingsAccount_NationalType_ReturnsCitiSavingsAccount()
        {
            ICreditUnionFactory factory = new SavingsAccountFactory();

            ISavingsAccount nationalAccount = factory.GetSavingsAccount(AccountType.National);

            Assert.IsType<NationalSavingsAccount>(nationalAccount);
        }
        [Fact]
        public void NationalSavingsAccount_Balance_Returns2000()
        {
            // Arrange
            ICreditUnionFactory factory = new SavingsAccountFactory();

            // Act
            ISavingsAccount nationalAccount = factory.GetSavingsAccount(AccountType.National);

            // Assert
            Assert.Equal(2000, nationalAccount.Balance);
        }

    }
}
