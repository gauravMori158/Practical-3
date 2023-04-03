using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
      class Sponsor
    {
        protected string owner = "Rakuteen";

    }

    class Team : Sponsor {
        private string teamName = " Gujarat Titans";
        public string concatedString; 

      
        public static void Main(string[] args)
        {
            Team team = new Team();
        

            team.concatedString=   team.PrintInfo(team.owner, team.teamName);
            Console.WriteLine("Concated String : "+team.concatedString);
        }
       
        /// <summary>
        /// PrintInfo method Takes two stirng argument and it returns concatineted string .
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="name"></param>
        /// <returns>string </returns>
        public string PrintInfo(string owner ,string name)
        {
         
            return owner+ name; 
        }
    
    }
}
