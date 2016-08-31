using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserValidation
{
    public class Validations
    {
        public static bool valid_firstName(string firstName)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Match match = regex.Match(firstName);
            return match.Success;
            
        }

         public static bool valid_lastName(string lastName)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Match match = regex.Match(lastName);
            return match.Success;

        }

        public static bool valid_userID(string uid)
        {
            Regex regex = new Regex("^[0-9]+$");
            Match match = regex.Match(uid);
            return match.Success;

        }
    }
}
