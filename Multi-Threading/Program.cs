using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static Multi_Threading.NumberHelper;

namespace Multi_Threading
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                        //create ThreadStart Delegate instance


                        ThreadStart delegateThread = new ThreadStart(ExThread.mythread1);
                        Thread t1 = new Thread(delegateThread);

                        //or
                        Thread thread = new Thread(new ThreadStart(ExThread.mythread1));

                        ParameterizedThreadStart PTS = new ParameterizedThreadStart(ExThread.thread3);
                        Thread t = new Thread(PTS);
                        t.Start("sds");
                        Console.Read();
            */

            ResultCallbackDelegate rcd = new ResultCallbackDelegate(ResultCallBackMethod);

            int num = 10;

            NumberHelper helper = new NumberHelper(num, rcd);

            Thread thread = new Thread(new ThreadStart(helper.CalculateSum));

            thread.Start();
            Console.Read();



        }
        public static void ResultCallBackMethod(int result)
        {
            Console.WriteLine($"The Result is:{result}");
        }
    }
    public class ExThread
    {
        public static void mythread1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("first thred");
            }
        }
        public static void thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void thread3(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }

    }

    public class Geek
    {
        public static void method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"this is on method1:{i}");
                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }
        public static void method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"this is on method2:{i}");

            }
            Console.WriteLine($"{Thread.CurrentThread.Name}");
        }
    }

    public class NumberHelper
    {
        // First Create the callback delegate with the same signature of the callback method.
        public delegate void ResultCallbackDelegate(int Results);

        int _Number;
        ResultCallbackDelegate _resultCallbackDelegate;

        public NumberHelper(int number, ResultCallbackDelegate resultCallbackDelegate)
        {
            this._Number = number;
            this._resultCallbackDelegate = resultCallbackDelegate;
        }

        public void CalculateSum()
        {
            int res = 0;
            for (int i = 0; i < _Number; i++)
            {
                res = res + i;
            }

            if (_resultCallbackDelegate != null)
            {
                _resultCallbackDelegate(res);
            }
        }
    }
}
