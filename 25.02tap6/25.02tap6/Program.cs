namespace _25._02tap6
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
                double percent20 = num * 20 / 100;
                double percent10 = percent20 * 10 / 100;
                double result = Math.Pow(percent10, 2);
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