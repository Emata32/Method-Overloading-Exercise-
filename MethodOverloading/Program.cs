namespace MethodOverloading
{
    public class Program
    {
        public static int Add (int one, int two)
        {
            return one + two;
        }

        public static decimal Add(decimal one, decimal two)
        {
            return one + two;
        }

        public static string Add(int one, int two, bool isCurrency)
        {
            var sum = one + two;

            if (isCurrency && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isCurrency && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return sum.ToString();
            }
                
        }
        static void Main(string[] args)
        { 
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1m, 2.5m));
            Console.WriteLine(Add(1, 0,true));
        }
    }
}
