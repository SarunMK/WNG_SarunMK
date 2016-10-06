using System.ServiceModel;

namespace WNG_Sarun_Service
{
    [ServiceContract(Namespace = "http://WNG_Sarun_Service")]
    public interface INumber
    {
        [OperationContract]
        long[] GetAllNumbers(long number);

        [OperationContract]
        long[] GetAllEvenNumbers(long number);

        [OperationContract]
        long[] GetAllOddNumbers(long number);

        [OperationContract]
        string[] GetAllNumbersExceptMultiplesOfThreeAndFive(long number);

        [OperationContract]
        long[] GetAllFibonacciNumbers(long number);
    }
}
