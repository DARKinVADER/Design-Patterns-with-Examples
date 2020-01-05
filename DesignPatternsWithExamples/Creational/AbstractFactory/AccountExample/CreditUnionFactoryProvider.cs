using System;

namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public static class CreditUnionFactoryProvider
    {
        public static ICreditUnionFactory GetCreditUnionFactory(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Citi:
                    return new CitiCreditUnionFactory();

                case AccountType.National:
                    return new NationalCreditUnionFactory();

                default:
                    throw new ArgumentException($"Invalid argument {accountType}");
            }
        }
    }
    public enum AccountType
    {
        Citi,
        National
    }
}