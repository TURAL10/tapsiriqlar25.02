namespace _25._02tap10
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
            if (uzunluq2 != 4)
            {
                goto l2;
            }
        l3:
            Console.Write("3-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num3);
            int uzunluq3 = (int)Math.Log10(num3) + 1;
            if (uzunluq3 != 4)
            {
                goto l3;
            }

            else
            {
                double percent1 = num1 * 1 / 100;
                double percent2 = num2 * 2 / 100;
                double percent3 = num3 * 3 / 100;
                double difference = percent1 - percent2 - percent3;
                double percent3_7 = num3 * 7 / 100;
                double result = difference + percent3_7;
                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}