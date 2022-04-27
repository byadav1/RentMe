using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentMe.Crypto;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the PasswordHash class.
    /// </summary>
    public class PasswordController
    {
        /// <summary>
        /// Return sha256 hash of a string 
        /// </summary>
        /// <param name="password"></param>
        /// <returns>sha256 hash string</returns>
        public string GetSha256Hash(string password)
        {
            return PasswordHash.GetSha256Hash(password);
        }
    }
}
