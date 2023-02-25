namespace _25._02tap13
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num1);
            int uzunluq1 = (int)Math.Log10(num1) + 1;
            if (uzunluq1 != 5)
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num2);
            int uzunluq2 = (int)Math.Log10(num2) + 1;
            if (uzunluq2 != 5)
            {
                goto l2;
            }
        l3:
            Console.Write("3-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num3);
            int uzunluq3 = (int)Math.Log10(num3) + 1;
            if (uzunluq3 != 5)
            {
                goto l3;
            }
        l4:
            Console.Write("4-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num4);
            int uzunluq4 = (int)Math.Log10(num4) + 1;
            if (uzunluq4 != 3)
            {
                goto l4;
            }
        l5:
            Console.Write("5-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num5);
            int uzunluq5 = (int)Math.Log10(num5) + 1;
            if (uzunluq5 != 3)
            {
                goto l5;
            }

            else
            {
                double percent1_5 = num1 * 5 / 100;
                double percent2_5 = num2 * 5 / 100;
                double percent3_5 = num3 * 5 / 100;
                double vurma_5 = percent1_5 * percent2_5 * percent3_5; 
                double percent4_3 = num4 * 3 / 100;
                double percent5_3 = num5 * 3 / 100;
                double sum_3 = percent4_3 + percent5_3;
                double result = (vurma_5 * 10 / 100) + (sum_3 * 10 / 100);
                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}  4cu reqem:{num4}  5ci reqem:{num5}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}