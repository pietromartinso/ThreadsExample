using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsExample
{
    class Account
    {
        private int balance = 1000;

        public Object locker = new Object();

        Random random = new Random();

        public void Withdraw()
        {
            lock (locker)
            {
                if (balance > 0)
                {
                    Console.WriteLine("{0} - Balance: {1}.", Thread.CurrentThread.Name, balance);
                    balance -= 100;

                    Thread.Sleep(random.Next(1, 10) * 100);
                    Console.WriteLine("New balance: {0}.", balance);
                } else
                {
                    Console.WriteLine("There is not enough balance.");
                }
            }
        }
    }
}
