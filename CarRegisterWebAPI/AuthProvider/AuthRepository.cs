using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRegisterWebAPI.Models
{
    public class AuthRepository
    {
        public bool ValidateUser(string username , string password)
        {
            if(username == "admin" && password == "helloworld")
            return true;

            else
            return false; 
        }
    }
}