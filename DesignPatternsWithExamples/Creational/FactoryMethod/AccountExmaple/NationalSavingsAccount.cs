namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExmaple
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
