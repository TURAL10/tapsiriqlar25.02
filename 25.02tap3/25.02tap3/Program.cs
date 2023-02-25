namespace _25._02tap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqemi daxil edin:");
            l1:
            double.TryParse(Console.ReadLine(), out double num);
            int uzunluq = (int)Math.Log10(num) + 1;

            if (uzunluq == 5)
            {
                double a = num * 18 / 100;
                double b = num * 3 / 100;
                Console.WriteLine($"18%={a}  3%={b}");
            }
            else
            {
                Console.Write("reqemi yeniden daxil edin:");
                goto l1;
            }
        }
    }
}