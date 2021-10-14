using System;

namespace HomeworkOne
{
    public partial class Program
    {
        /// <summary>
        /// Adds the two numbers.
        /// </summary>
        /// <returns></returns>
        public static void AddTwoNumbers()
        {
            Console.WriteLine("Inside AddTwoNumbers method");
            
            Console.Write("Type a number, and then press Enter: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type another number, and then press Enter: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            var sum = num1 + num2;

            Console.WriteLine($"Your result: {num1} + {num2} = {sum}");
        }
    }
}
