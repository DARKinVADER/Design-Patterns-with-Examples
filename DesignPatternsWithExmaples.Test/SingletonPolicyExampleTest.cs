using DesignPatternsWithExamples.Creational.Singleton.PolicyExample;
using Xunit;

namespace DesignPatternsWithExmaples.Test
{
    public class SingletonPolicyExampleTest
    {
        [Fact]
        public void IsPolicyASingleton()
        {
            Assert.Same(Policy.Instance, Policy.Instance);
        }
    }
}
