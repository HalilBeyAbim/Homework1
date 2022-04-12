using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 =2;
            int N2 = 2;

        
            if (N1 > N2) 
            {
                Console.WriteLine(N1);
            }
            else if (N1 < N2) 
            {
                Console.WriteLine(N2);
            }
            else
            {
                Console.WriteLine("sayi beraberdir");
            }
            Console.ReadKey();
        }
    } 
}
