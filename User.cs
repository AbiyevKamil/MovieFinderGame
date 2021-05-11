using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinderGame
{
    class User
    {
        public int score;
        public string username;

        public User(int score, string username)
        {
            this.score = score;
            this.username = username;
        }
    }
}
