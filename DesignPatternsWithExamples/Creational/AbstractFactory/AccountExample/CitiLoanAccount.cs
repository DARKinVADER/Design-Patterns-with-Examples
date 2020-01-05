namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public class CitiLoanAccount : ILoanAccount
    {
        public int InterestRate { get; set; } = 7;
    }
}