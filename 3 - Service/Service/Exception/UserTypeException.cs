using System;

namespace LojaZero.Service.Exception
{
    public class UserTypeException: ApplicationException
    {
        public UserTypeException():base("User Type not found.")
        {
        }   

    }
}