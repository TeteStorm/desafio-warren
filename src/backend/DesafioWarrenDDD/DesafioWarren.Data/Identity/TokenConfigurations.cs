﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioWarren.Data.Identity
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
