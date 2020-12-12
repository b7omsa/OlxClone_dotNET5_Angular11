﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AuthUserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public AuthUserDTO(AppUser user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;
        }
    }
}
