using NLBank.client.MODEL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.MODEL
{
    public class Authentication
    {
        public string ID { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public Role RoleID { set; get; }
    }
}
