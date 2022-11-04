using NLBank.client.BASE;
using NLBank.client.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DAO.Interface
{
    public interface AuthenticationInterface
    {
        AppResponse<bool> SignIn(string email, string password); 
    }
}
