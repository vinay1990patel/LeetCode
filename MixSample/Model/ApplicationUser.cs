﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace MixSample.Model
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
