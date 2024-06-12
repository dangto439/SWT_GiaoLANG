namespace mathUtil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            var check  = MathUtility.IsPrime(n);
            if (check)
            {
                Console.WriteLine(n + " is prime");
            }
        }
    }
}
