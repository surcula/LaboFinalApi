﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Roles Roles { get; set; }
    }
}
