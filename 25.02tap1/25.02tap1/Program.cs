namespace _25._02tap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("reqemi daxil edin:");
            l1:
            int.TryParse(Console.ReadLine(), out int num);
            int uzunluq = (int)Math.Log10(num) + 1;

            if (uzunluq == 4) 
            {
                int a = 7 *(int)Math.Pow(10, uzunluq + 1);
                num *= 10;
                int result = a + num + 8;
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