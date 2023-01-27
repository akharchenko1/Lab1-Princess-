using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Friend
    {
        Hall hall;
        public Friend(Hall lhall)
        {
            hall = lhall;
        }
        public bool sravniDvuh(string thisJenih, string otherJenih)
        {
            return (hall.getJenihHappy(thisJenih) > hall.getJenihHappy(otherJenih));
        }
    }
}
