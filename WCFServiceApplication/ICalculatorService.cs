using System.ServiceModel;

namespace WCFServiceApplication
{
    // Define a service contract
    // ServiceContract is the short name for System.ServiceModel.ServiceContractAttribute
    [ServiceContract]
    public interface ICalculatorService
    {
        // Define an operation contract
        // OperationContract is the short name for System.ServiceModel.OperationContractAttribute
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);
    }
}
