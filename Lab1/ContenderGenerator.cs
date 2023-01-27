using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ContenderGenerator
    {
        private ArrayList arr = new ArrayList();
        private string[] names;
        private string[] father_names;
        private bool[] happy;
        public ContenderGenerator()
        {
            names = new string[10] { "Александр", "Иван", "Сергей", "Андрей", "Алексей", "Пётр", "Артём", "Данил", "Никита", "Ефим" };
            father_names = new string[10] { " Александрович", " Иванович", " Сергеевич", " Андреевич", " Алексеевич", " Петрович", " Артёмович", " Данилович", " Никитич", " Ефимович"};
            happy = new bool[100];
            int number;
            Random ran = new Random();
            for (int i = 0; i < names.Length; i++)
                for (int j = 0; j < father_names.Length; j++)
                { 
                    number = ran.Next(0, 99);
                    if (happy[number] == true)
                    {
                        number = Array.IndexOf(happy, false);
                    }
                    happy[number] = true;
                    arr.Add(new Tuple<int,string>(number + 1,names[i] + father_names[j]));
                }
        }

        public Tuple<int, string> getJenih(int index)
        {
            return (Tuple<int, string>)arr[index];
        }

        public void deleteJenih(int index)
        {
            arr.RemoveAt(index);
        }

        public int countJenihs()
        {
            return arr.Count;
        }
    }
}
