namespace _25._02tap14
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
        l5:
            Console.Write("5-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num5);
            int uzunluq5 = (int)Math.Log10(num5) + 1;
            if (uzunluq5 != 6)
            {
                goto l5;
            }
        l6:
            Console.Write("6-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num6);
            int uzunluq6 = (int)Math.Log10(num6) + 1;
            if (uzunluq6 != 6)
            {
                goto l6;
            }

            else
            {
                double allSum = num1 + num2 + num3 + num4 + num5 + num6;
                string sum1_3 = Convert.ToString(num1) + num3;
                double differens = allSum - Convert.ToDouble(sum1_3);
                double percent_10 = differens * 10 / 100;
                double lastSum = percent_10 + num5 + num6;
                double result = lastSum * 11 / 100;
                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}");
                Console.WriteLine($"4cu reqem:{num4}  5ci reqem:{num5}  6ci reqem:{num6}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}