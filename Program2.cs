using System.Text;

namespace _25._02
{
    public class Program2
    {
        static bool IsFibonacci(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Число не може бути негативним");
            }

            int a = 0, b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            try
            {
                int number = int.Parse(Console.ReadLine());
                bool isFibonacci = IsFibonacci(number);
                Console.WriteLine($"Число {number} {(isFibonacci ? "є" : "не є")} числом Фібоначчі");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Невірний формат даних!");
            }
            Console.ReadKey();
        }
    }
}