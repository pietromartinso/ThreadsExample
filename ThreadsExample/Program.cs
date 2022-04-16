using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadsExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Thread thread01 = new Thread(MetodoThread);
            thread01.Start();

            Console.Read();
        }
    
        public static void MetodoThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread sendo executada.");
            }        
        }
    
    }
}