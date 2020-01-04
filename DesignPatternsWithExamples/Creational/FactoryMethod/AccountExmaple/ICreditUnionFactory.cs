namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExmaple
{
    // Creator
    public interface ICreditUnionFactory
    {
        public ISavingsAccount GetSavingsAccount(AccountType accountType);
    }

    public enum AccountType
    {
        Citi,
        National
    }
}
