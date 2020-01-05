namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExample
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
