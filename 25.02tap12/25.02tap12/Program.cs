namespace _25._02tap12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num1);
            int uzunluq1 = (int)Math.Log10(num1) + 1;
            if (uzunluq1 != 6)
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num2);
            int uzunluq2 = (int)Math.Log10(num2) + 1;
            if (uzunluq2 != 6)
            {
                goto l2;
            }
        l3:
            Console.Write("3-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num3);
            int uzunluq3 = (int)Math.Log10(num3) + 1;
            if (uzunluq3 != 6)
            {
                goto l3;
            }
        l4:
            Console.Write("4-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num4);
            int uzunluq4 = (int)Math.Log10(num4) + 1;
            if (uzunluq4 != 6)
            {
                goto l4;
            }

            else
            {
                double percent1_10 = num1 * 10 / 100;
                double percent2_10 = num2 * 10 / 100;
                double percent3_10 = num3 * 10 / 100;
                double percent4_10 = num4 * 10 / 100;
                double sum_10 = percent1_10 + percent2_10 + percent3_10 + percent4_10;
                double percent1_15 = num1 * 15 / 100;
                double percent2_15 = num2 * 15 / 100;
                double percent3_15 = num3 * 15 / 100;
                double percent4_15 = num4 * 15 / 100;
                double sum_15 = percent1_15 + percent2_15 + percent3_15 + percent4_15;
                double vurma = sum_10 * sum_15;
                double result = vurma * 10 / 100 * 11 / 100;
                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}  4cu reqem:{num4}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}