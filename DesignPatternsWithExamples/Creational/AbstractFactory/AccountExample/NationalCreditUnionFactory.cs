namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public class NationalCreditUnionFactory : ICreditUnionFactory
    {
        public ISavingsAccount CreateSavingsAccount()
        {
            return new NationalSavingsAccount();
        }

        public ILoanAccount CreateLoanAccount()
        {
            return new NationalLoanAccount();
        }
    }
}
