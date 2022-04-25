using System;

namespace datetime_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            DateTime tijd = new DateTime();
            do
            {
                Console.WriteLine(tijd.ToLongTimeString());
                System.Threading.Thread.Sleep(1000);
                tijd = tijd.AddSeconds(1);
                Console.Clear();
            } while (loop == 1);
        }
    }
}
