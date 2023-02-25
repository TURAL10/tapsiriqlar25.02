namespace _25._02tap15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        l1:
            Console.Write("1-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num1);
            int uzunluq1 = (int)Math.Log10(num1) + 1;
            if (uzunluq1 != 3)
            {
                goto l1;
            }
        l2:
            Console.Write("2-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num2);
            int uzunluq2 = (int)Math.Log10(num2) + 1;
            if (uzunluq2 != 3)
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
        l4:
            Console.Write("4-cu reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num4);
            int uzunluq4 = (int)Math.Log10(num4) + 1;
            if (uzunluq4 != 4)
            {
                goto l4;
            }
        l5:
            Console.Write("5-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num5);
            int uzunluq5 = (int)Math.Log10(num5) + 1;
            if (uzunluq5 != 5)
            {
                goto l5;
            }
        l6:
            Console.Write("6-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num6);
            int uzunluq6 = (int)Math.Log10(num6) + 1;
            if (uzunluq6 != 5)
            {
                goto l6;
            }
        l7:
            Console.Write("7-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num7);
            int uzunluq7 = (int)Math.Log10(num7) + 1;
            if (uzunluq7 != 6)
            {
                goto l7;
            }

            else
            {
                double sum_3 = num1 + num2;
                double sum_4 = num3 + num4;
                double vurma_4 = num3 * num4;
                double sum_s3_v4 = sum_3 + vurma_4;
                double sum_5 = num5 + num6;
                double add_7 = sum_s3_v4 * 10 + 7;
                double sum_s5_add7 = sum_5 + add_7;
                double vurma_3 = num1 * num2 * 10 + 1;
                double differens = sum_s5_add7 - vurma_3;
                double sum_6 = differens + num7;
                double result_1 = sum_6 - (sum_3 + sum_4);
                double result_2 = result_1  / 100 * 3 / 100 * 1 / 100 * 18;
                double endResult = result_2 + sum_5;

                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}");
                Console.WriteLine($"4cu reqem:{num4}  5ci reqem:{num5}  6ci reqem:{num6}  7ci reqem:{num7}");
                Console.WriteLine($"alinan cavab:{endResult}");
            }
        }
    }
}