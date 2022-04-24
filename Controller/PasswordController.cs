using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.Crypto;

namespace RentMe.Controller
{
    public class PasswordController
    {
        public string GetSha256Hash(string password)
        {
            return PasswordHash.GetSha256Hash(password);
        }
    }
}
