namespace _25._02tap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqemi daxil edin:");
            l1:
            double.TryParse(Console.ReadLine(), out double num);
            int uzunluq = (int)Math.Log10(num) + 1;

            if (uzunluq == 3)
            {
                num *= 10;
                double a = num + 7;
                double result = a * 7 / 100;
                Console.WriteLine(result);
            }
            else
            {
                Console.Write("reqemi yeniden daxil edin:");
                goto l1;
            }
        }
    }
}