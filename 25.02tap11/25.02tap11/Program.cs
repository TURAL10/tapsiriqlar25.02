namespace _25._02tap11
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
            if (uzunluq4 != 5)
            {
                goto l4;
            }

            else
            {
                double sum1_3 = num1 + num3;
                double sum2_4 = num2 + num4;
                double vurma = sum1_3 * sum2_4;
                double percent3_3 = num3 * 3 / 100;
                double result = vurma - percent3_3;
                Console.WriteLine($"1ci reqem:{num1}  2ci reqem:{num2}  3cu reqem:{num3}  4cu reqem:{num4}");
                Console.WriteLine($"alinan cavab:{result}");
            }
        }
    }
}