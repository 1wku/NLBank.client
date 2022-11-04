using NLBank.client.BASE;
using NLBank.client.DAO.Interface;
using NLBank.client.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAO
{
    public class Authentication : AuthenticationInterface
    {
        public AppResponse<bool> SignIn(string email, string password)
        {

            return new AppResponse<bool>(true);
        }

    }
}
