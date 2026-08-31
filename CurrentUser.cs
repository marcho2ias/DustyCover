using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DustyCover
{
    internal class CurrentUser
    {
        
        
            public static User LoggedInUser;

            public static bool IsLoggedIn()
            {
                return LoggedInUser != null;
            }

            public static void Logout()
            {
                LoggedInUser = null;
            }
        
    }
}
