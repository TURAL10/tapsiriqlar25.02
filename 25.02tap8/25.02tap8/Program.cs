namespace _25._02tap8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num1);
            int uzunluq1 = (int)Math.Log10(num1) + 1;
            if (uzunluq1 != 4)
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num2);
            int uzunluq2 = (int)Math.Log10(num2) + 1;
            if (uzunluq2 != 7)
            {
                goto l2;
            }

            else
            {
                double percent1 = num1 * 4 / 100;
                double percent2 = num2 * 9 / 100;
                double sum = percent1 + percent2;
                double result = sum * 10 / 100;
                Console.WriteLine($"1-ci reqem:{num1}  2ci reqem:{num2}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}