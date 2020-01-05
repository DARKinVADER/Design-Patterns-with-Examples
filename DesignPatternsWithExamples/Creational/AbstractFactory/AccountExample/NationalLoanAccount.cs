namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public class NationalLoanAccount : ILoanAccount
    {
        public int InterestRate { get; set; } = 10;
    }
}