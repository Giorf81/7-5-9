namespace _7_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
        }
    }

    static class IntExtensions
    {
        public static int GetNegative(this int qwe)
        {
            if (qwe <= 0)
                return qwe;
            else
                return qwe * -1;
        }
        public static int GetPositive(this int qwe)
        {
            if (qwe >= 0)
                return qwe;
            else 
                return qwe * -1;
        }
    }
}
