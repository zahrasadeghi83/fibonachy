namespace fibonachy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            int a = 0;
            int b = 1;
            int n = 10;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(b);
                c = a + b;
                a = b;
                b = c;
            }
            
        }
    }
}
