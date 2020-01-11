namespace DesignPatternsWithExamples.Creational.Singleton.PolicyExample
{
    public class Policy
    {
        private static readonly object _lock = new object();
        private static Policy _instance;
        public static Policy Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Policy();
                    }

                    return _instance;
                }
            }
        }

    }
}
