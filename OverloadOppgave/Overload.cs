using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOppgave
{
    internal class Overload
    {
        public string welcomeMsg = "Greetings and salutations! ";
        public void WelcomeMessage()
        {
            
            Console.WriteLine(welcomeMsg);
        }
        public void WelcomeMessage(string extraMsg = "You smell")
        {
            
            Console.WriteLine(welcomeMsg + extraMsg);
            
        }
        
    }
}
