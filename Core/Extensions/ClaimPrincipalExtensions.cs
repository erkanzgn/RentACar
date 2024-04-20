﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static  class ClaimPrincipalExtensions
    {
        public static List<string>Claims(this ClaimsPrincipal claimPrincipal,string claimType)
        {
            var result = claimPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }
        public static List<string> ClaimRules(this ClaimsPrincipal claimPrincipal)
        {
            return claimPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
