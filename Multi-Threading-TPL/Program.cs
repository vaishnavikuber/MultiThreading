using System;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threading_TPL
{
    internal class Program
    {

        static async Task Main()
        {
            //Task task1 = Task.Run(() => TPLPractice.PrintNumbers());
            //Task task2 = Task.Run(() => TPLPractice.PrintNumbers());

            //await Task.WhenAll(task1, task2);

            //Console.WriteLine("Both Tasks completed");

            TPLPractice.CallMethod1();
            TPLPractice.CallMethod2();
            Console.WriteLine("Finished");
        
        
        }


        //static void Main(string[] args)
        //{
        //    Thread thread1 = new Thread(MultiThreadingPractice.PrintNumbers);
        //    Thread thread2 = new Thread(MultiThreadingPractice.PrintNumbers);

        //    thread1.Start();
        //    thread2.Start();

        //    thread1.Join();
        //    thread2.Join();

        //    Console.WriteLine("Both Threads are completed");
        //}
    }
}
