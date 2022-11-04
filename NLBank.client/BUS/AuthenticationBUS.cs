using NLBank.client.BASE;
using NLBank.client.DAO;
using NLBank.client.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.BUS
{
    public class AuthenticationBUS
    {
        IAuthenticationDAO authenticationDAO = new AuthenticationDAO();
        public AppResponse<bool> SignIn(String email , string password)
        {
            return authenticationDAO.SignIn(email, password);
        }
    }
}
