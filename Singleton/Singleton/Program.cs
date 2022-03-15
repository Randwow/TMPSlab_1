using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Singleton teamLead = Singleton.GetInstance;
            teamLead.PrintDetails("You create Team Lead position");
            Singleton teamLead2 = Singleton.GetInstance;
            if (teamLead.Equals(teamLead2))
            {
                teamLead2.PrintDetails("You do not create new team lead");
            }
        }
    }
}
