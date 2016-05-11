using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    public static class clsLogin
    {
        private static string userRollNo = "";

        public static string UserRoll
        {
             get { return userRollNo; }
            set { userRollNo = value; }
        }
    }
}
