using System.Text;

namespace _25._02
{
    public class Program
    {
        static int MultiplyRange()
        {
            int start, end;

            Console.Write("Введіть початкове значення діапазону: ");
            string inputStart = Console.ReadLine();
            start = int.Parse(inputStart);

            Console.Write("Введіть кінцеве значення діапазону: ");
            string inputEnd = Console.ReadLine();
            end = int.Parse(inputEnd);

            if (start > end)
            {
                throw new ArgumentException("Початкове значення не може бути більше кінцевого");
            }

            int product = 1;
            for (int i = start; i <= end; i++)
            {
                product *= i;
            }
            return product;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            try
            {
                int result = MultiplyRange();
                Console.WriteLine($"Добуток чисел у діапазоні: {result}");
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
