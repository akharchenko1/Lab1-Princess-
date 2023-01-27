using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Hall
    {
        ContenderGenerator jenihs;
        private LinkedListNode<Tuple<int, string>> node;
        private LinkedList <Tuple<int, string>> waiting;
        private LinkedList <Tuple<int, string>> afterPrincess;
        public Hall()
        {
            jenihs = new ContenderGenerator();
            waiting = new LinkedList<Tuple<int, string>>();
            afterPrincess = new LinkedList<Tuple<int, string>>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int index = rand.Next(0, jenihs.countJenihs() - 1);
                waiting.AddFirst(jenihs.getJenih(index));
                jenihs.deleteJenih(index);
            }
            node = waiting.First;
        }

        public string getNextJenih()
        {
            if (node != null)
            {
                afterPrincess.AddFirst(node.Value);
                string jenihName = node.Value.Item2;
                node = node.Next;
                return jenihName;
            }
            else
            {
                return "end";
            }
        }

        public int getJenihHappy(string name)
        {
            LinkedListNode<Tuple<int, string>> anode = afterPrincess.First;
            while (anode != null)
            {
                if (anode.Value.Item2 == name)
                {
                    return anode.Value.Item1;
                }
                else
                {
                    anode = anode.Next;
                }
            }
            return -1;
        }
    }
}
