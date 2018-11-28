using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace SingleService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple,
        InstanceContextMode = InstanceContextMode.PerSession)]
    public class SingleService : ISingleService
    {
        public List<int> GetEvenNumbers(int n)
        {
            Console.WriteLine("Thread {0} started processing GetEvenNumbers at {1}",
                Thread.CurrentThread.ManagedThreadId,
                DateTime.Now.ToString());

            List<int> evenNumberList = new List<int>();
            for(int i = 0; i < n; i += 2)
            {
                evenNumberList.Add(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread {0} stopped processing GetEvenNumbers at {1}",
                Thread.CurrentThread.ManagedThreadId,
                DateTime.Now.ToString());
            return evenNumberList;
        }

        public List<int> GetOddNumbers(int n)
        {
            Console.WriteLine("Thread {0} started processing GetOddNumbers at {1}",
                Thread.CurrentThread.ManagedThreadId,
                DateTime.Now.ToString());

            List<int> oddNumberList = new List<int>();
            for (int i = 1; i < n; i += 2)
            {
                oddNumberList.Add(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Thread {0} stopped processing GetOddNumbers at {1}",
                Thread.CurrentThread.ManagedThreadId,
                DateTime.Now.ToString());
            return oddNumberList;
        }
    }
}
