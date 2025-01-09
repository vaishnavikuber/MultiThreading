using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Threading_TPL
{
    internal class TPLPractice
    {

        public static void PrintNumbers()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Task {Task.CurrentId}");
                Task.Delay(1000).Wait();
            }
        }

        public static async Task CallMethod1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Method 1");
                    Task.Delay(1000).Wait();
                }

            });
            
        }

        public static void CallMethod2()
        {
            for( int i = 0;i<20 ; i++)
            {
                Console.WriteLine("Method 2");
                Task.Delay(1000).Wait();
                
            }
        }

    }
}
