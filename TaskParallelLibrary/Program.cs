using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartThread();
            //StartForEach();
            //StartFor();
            StartCancel();
            Console.WriteLine("Completed all tasks !");
        }

        static void StartCancel()
        {
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => SimpleWork(1, 1000, source.Token)).ContinueWith((prev) => HarderWork(1, 500));
                source.Cancel();

                var list = new List<Task> { t1 };
                Task.WaitAll(list.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
            }
        }

        static void StartFor()
        {
            Parallel.For(0, 100, (i) => Console.WriteLine(i));
        }

        static void StartForEach()
        {
            var list = new List<int> { 1, 2, 3, 4, 8, 10, 20, 30, 50, 5, 6, 7 };
            Parallel.ForEach(list, (i) => Console.WriteLine(i));
        }

        static void StartThread()
        {
            var t1 = Task.Factory.StartNew(() => { SimpleWork(1, 1500); }).ContinueWith((prev) => HarderWork(1, 1000));
            var t2 = Task.Factory.StartNew(() => { SimpleWork(2, 3000); }).ContinueWith((prev) => HarderWork(2, 2000));
            var t3 = Task.Factory.StartNew(() => { SimpleWork(3, 1000); }).ContinueWith((prev) => HarderWork(3, 5000));

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(">> Doing some tasks in parallel.");
                Thread.Sleep(500);
                Console.WriteLine(">> Finished the parallel id {0}", i);
            }

            var list = new List<Task> { t1, t2, t3 };
            Task.WaitAll(list.ToArray());
        }

        static void SimpleWork(int id, int sleepTime)
        {
            Console.WriteLine("Simple work id {0} started", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Simple work id {0} completed", id);
        }

        static void HarderWork(int id, int sleepTime)
        {
            Console.WriteLine("Harder work id {0} started", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Harder work id {0} completed", id);
        }

        static void SimpleWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancelllation requested !");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Simple work id {0} started", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Simple work id {0} completed", id);
        }

        static void HarderWork(int id, int sleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancelllation requested !");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Harder work id {0} started", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("Harder work id {0} completed", id);
        }
    }
}
