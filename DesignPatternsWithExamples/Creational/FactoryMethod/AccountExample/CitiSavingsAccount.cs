namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExample
{
    // Concrete Product
    public class CitiSavingsAccount : ISavingsAccount
    {
        public CitiSavingsAccount()
        {
            Balance = 5000;
        }
    }
}
