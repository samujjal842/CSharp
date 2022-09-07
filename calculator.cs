using System;
 namespace Addition
{
    public class Program
    {
        public static int add(int a, int b)
        {
            return (a + b);
        }
        public static int substraction(int a, int b)
        {
            return (a - b);
        }
        public static int multiplication(int a, int b)
        {
            return (a * b);
        }
        public static float division(int a, int b)
        {
            return (a / b);
        }
        public static void Main()
        {
            int sum, sub, multiply;
            float divide;
            Console.WriteLine("Enter the first number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int b = int.Parse(Console.ReadLine());
            sum =add(a,b);
            Console.WriteLine("The sum is : {0}",sum);
            sub =substraction(a,b);
            Console.WriteLine("The substraction result is : {0}",sub);
            multiply = multiplication(a, b);
            Console.WriteLine("The multiplication result is : {0}",multiply);
            divide = division(a, b);
            Console.WriteLine("The division result is : {0}", divide);
        }
    }
}
