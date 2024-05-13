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

            #region Queue (fila - FIFO)

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

            Stack<int> stackIntegers = new Stack<int>();

            stackIntegers.Push(0);
            stackIntegers.Push(1);

            for (int i = 2; i < 4; i++)
            {
                stackIntegers.Push(i);
            }

            Utility.WriteTitle("Push", "\n", "\n");

            foreach (int item in stackIntegers)
            {
                Utility.WriteMessage(item.ToString(), "\n");
            }

            Utility.WriteTitle("Pop", "\n", "\n");

            int countStack = stackIntegers.Count;

            for (int i = 0; i < countStack; i++)
            {
                Utility.WriteMessage($"{stackIntegers.Pop()}", "\n");
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
