using System;
using System.Threading;

namespace BasicThreading
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int LoopCount = 0; LoopCount <= 5; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;

                Console.WriteLine(
                    "Name of Thread: " +
                    thread.Name +
                    " Process = " +
                    LoopCount
                );

                Thread.Sleep(1500);
            }
        }
    }
}