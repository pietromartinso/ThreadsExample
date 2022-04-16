using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsExample
{
    class Conta
    {
        private int saldo = 1000;

        Random random = new Random();

        public void Saque()
        {
            if (saldo > 0)
            {
                Console.WriteLine("Thread: {0}", Thread.CurrentThread.Name);
                Console.WriteLine(saldo);
                saldo -= 100;

                Thread.Sleep(random.Next(1, 10) * 100);
                Console.WriteLine("Novo saldo: {0}.", saldo);
            } else
            {
                Console.WriteLine("Não há saldo suficiente.");
            }



        }
    }
}
