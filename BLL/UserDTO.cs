﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BLL
{
    internal class UserDTO
    {
        public int ID {get;set;}
        public string Login { get;set;}
        public string Password{ get;set;}
        public enum Type
        {
            Admin,
            Casual
        }


    }
}
