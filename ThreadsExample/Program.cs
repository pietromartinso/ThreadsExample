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
            Account acc = new Account();

            Thread[] threads = new Thread[12];

            for (int i = 0; i < threads.Length; i++)
            {
                Thread thread = new Thread(acc.Withdraw);
                thread.Name = "Thread " + i;
                threads[i] = thread;
            }

            foreach (var item in threads)
            {
                item.Start();
            }

            Console.Read();
        }
    
    }
}