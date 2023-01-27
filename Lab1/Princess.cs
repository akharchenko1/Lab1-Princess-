using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab1
{
    class Princess
    {
        public Princess()
        {
            using (StreamWriter writer = File.CreateText("Jenihi.txt"))
            {
                Hall hall = new Hall();
                Friend friend = new Friend(hall);
                LinkedList<string> jenihi = new LinkedList<string>();
                string thisJenih = hall.getNextJenih();
                jenihi.AddFirst(thisJenih);
                writer.WriteLine(thisJenih);
                int otnhappy = 0;
                while (otnhappy < 51)
                {
                    otnhappy = 0;
                    thisJenih = hall.getNextJenih();
                    if (thisJenih != "end")
                    {
                        LinkedListNode<string> anode = jenihi.First;
                        while (anode != null)
                        {
                            if (friend.sravniDvuh(thisJenih, anode.Value))
                            {
                                otnhappy++;
                                anode = anode.Next;
                            }
                            else
                            {
                                jenihi.AddBefore(anode, thisJenih);
                                break;
                            }
                        }
                        writer.WriteLine(thisJenih);
                        if (anode == null)
                        {
                            jenihi.AddLast(thisJenih);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                writer.WriteLine("--------------------------------------");
                if (thisJenih == "end")
                {
                    writer.WriteLine(10);
                }
                else
                {
                    writer.WriteLine(hall.getJenihHappy(thisJenih));
                }
            }
        }
    }
}
