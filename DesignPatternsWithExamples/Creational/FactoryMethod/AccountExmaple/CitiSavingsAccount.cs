namespace DesignPatternsWithExamples.Creational.FactoryMethod.AccountExmaple
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
