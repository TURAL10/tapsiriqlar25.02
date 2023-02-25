namespace _25._02tap5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqemi daxil edin:");
            l1:
            double.TryParse(Console.ReadLine(), out double num);
            int uzunluq = (int)Math.Log10(num) + 1;

            if (uzunluq == 4)
            {
                double a = 4 * (int)Math.Pow(10, uzunluq + 2);
                num *= 100;
                double sum = a + num + 44;
                double result = sum * 44 / 100;
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