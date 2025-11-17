namespace WCFServiceApplication
{
    // This class implements the service contract defined in IService.cs
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }

        public int Subtract(int a, int b)
        {
            return (a - b);
        }
    }
}
