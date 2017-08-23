using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cw
{
    class Program { 
        static void Main(string[] args)
        {
            User user = new User();

            user.CreationDate = null;
            user.Login = null;
            user.IsDeleted = null;
            user.Type = null;
        }
    }
}
