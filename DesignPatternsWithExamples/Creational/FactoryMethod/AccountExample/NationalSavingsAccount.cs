namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExample
{
    // Concrete Product
    public class NationalSavingsAccount : ISavingsAccount
    {
        public NationalSavingsAccount()
        {
            Balance = 2000;
        }
    }
}
