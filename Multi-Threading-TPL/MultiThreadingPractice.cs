using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multi_Threading_TPL
{
    internal class MultiThreadingPractice
    {

        public static void PrintNumbers()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
        }

    }
}
