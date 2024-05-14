using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D17_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Queue<T>: fila - FIFO (first-in-first-out)

            Utility.WriteTitle("Queue<T>: fila - FIFO (first-in-first-out)", "\n", "\n");

            Queue<int> queueIntegers = new Queue<int>();

            queueIntegers.Enqueue(0);
            queueIntegers.Enqueue(1);

            for (int i = 2; i < 4; i++)
            {
                queueIntegers.Enqueue(i);
            }

            Utility.WriteTitle("Enqueue", "\n", "\n");

            foreach (int item in queueIntegers)
            {
                Utility.WriteMessage(item.ToString(), "\n");    // 0, 1, 2, 3
            }

            Utility.WriteTitle("Dequeue", "\n", "\n");

            int countQueue = queueIntegers.Count;   // 4

            for (int i = 0; i < countQueue; i++)
            {
                Utility.WriteMessage($"{queueIntegers.Dequeue()}", "\n");
            }

            
            #endregion

            Utility.TerminateConsole();
        }
    }
}
