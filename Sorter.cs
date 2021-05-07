using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFInderApp
{
    class Sorter : IComparer<User>
    {
        public int Compare(User first, User second)
        {
            if (first.score < second.score) return +1;
            else if (first.score > second.score) return -1;
            return 0;
        }
    }
}
