using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the Identity Class to be used with the CharacterPortfolio class
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class Identity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> FirstNameList;
        public List<string> LastNameList;

        public void LoadNames()
        {
            StreamReader fnl = new StreamReader("firstNames.txt");
            StreamReader lnl = new StreamReader("lastNames.txt");
        }
        //public void GenerateNames()
        //{
        //    Random firstname = 
        //}

    }
}
