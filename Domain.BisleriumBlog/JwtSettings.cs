﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BisleriumBlog
{
    public class JwtSettings
    {
        public string? Issuer { get; set; }
        public string? Audience { get;set; }
        public string? SigningKey { get; set; }
    }
}
