namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    // Abstract Factory
    public interface ICreditUnionFactory
    {
        ISavingsAccount CreateSavingsAccount();
        ILoanAccount CreateLoanAccount();
    }
}
