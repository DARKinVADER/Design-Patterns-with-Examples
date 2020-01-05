namespace DesignPatternsWithExamples.Creational.AbstractFactory.AccountExample
{
    public class CitiSavingsAccount : ISavingsAccount
    {
        public int Balance { get; set; } = 1000;
    }
}