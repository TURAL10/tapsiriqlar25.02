namespace _25._02tap7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.Write("1-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num1);
            int uzunluq1 = (int)Math.Log10(num1) + 1;
            if(uzunluq1 !=5 )
            {
                goto l1;
            }
            l2:
            Console.Write("2-ci reqemi daxil edin:");
            double.TryParse(Console.ReadLine(), out double num2);            
            int uzunluq2 = (int)Math.Log10(num2) + 1;
            if(uzunluq2 !=5 )
            {
                goto l2;
            }
            
            else             
            {
                double sum = num1 + num2;
                int sumUzunluq = (int)Math.Log10(sum) + 2;
                double a = 5 * Math.Pow(10, sumUzunluq);
                sum *= 10;
                double sumResult = a + sum + 5;
                double percentResult = sumResult * 5 / 100;
                Console.WriteLine($"1-ci reqem:{num1}  2ci reqem:{num2}");
                Console.WriteLine($"alinan cavab:{percentResult}");
            }
           
        }
    }
}