namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public class CitiCreditUnionFactory : ICreditUnionFactory
    {
        public ISavingsAccount CreateSavingsAccount()
        {
            return new CitiSavingsAccount();
        }

        public ILoanAccount CreateLoanAccount()
        {
            return new CitiLoanAccount();
        }
    }
}