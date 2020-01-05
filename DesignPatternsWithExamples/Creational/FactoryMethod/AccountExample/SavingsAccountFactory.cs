using System;

namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExample
{
    // Concrete Creator
    public class SavingsAccountFactory : ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Citi:
                    return new CitiSavingsAccount();

                case AccountType.National:
                    return new NationalSavingsAccount();

                default:
                    throw new ArgumentException("Invalid Account Type");
            }
        }
    }
}
