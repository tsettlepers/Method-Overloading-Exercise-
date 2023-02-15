namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Method Overloading Exercise!");
            Console.WriteLine($"Integer form of Add(4,5) is {Add(4,5)}");
            Console.WriteLine($"Decimal form of Add(3.14,4.25) is {Add(3.14m,4.25m)}");
            Console.WriteLine($"String form of Add(0,1,True) is {Add(0,1,true)}");
            Console.WriteLine($"String form of Add(4,1,True) is {Add(4, 1, true)}");
            Console.WriteLine($"String form of Add(3,1,False) is {Add(3, 1, false)}");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static string Add(int x, int y, bool isDollars)
        {
            if (isDollars)
                return $"{x + y} " + (x + y == 1 ? "dollar" : "dollars");
            else
                return $"{x + y}";
        }
    }
}
