using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation9Lab
{
    class Team
    {
        public int score, wins = 0, losses = 0, goalsScore = 0, missedGoalsScore = 0;
        string name;
        decimal lambda;
        public Team(string name, decimal lambda)
        {
            this.name = name;
            this.lambda = lambda;
        }
    }
}
