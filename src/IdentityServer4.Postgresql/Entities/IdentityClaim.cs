﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer4.Postgresql.Entities
{
    public class IdentityClaim: UserClaim
    {
        public IdentityResource IdentityResource { get; set; }
    }
}
