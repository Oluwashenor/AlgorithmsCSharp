namespace AlgorithmsCSharp
{
    public class Algorithms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int validPair = SockMerchant.sockMerchant(5, ar);
            //Console Writeline out valid Pair
            Console.WriteLine(validPair);
            
        }
    }

}