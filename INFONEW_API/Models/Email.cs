﻿using System;
using System.Collections.Generic;

#nullable disable

namespace INFONEW_API.Models
{
    public partial class Email
    {
        public int NumLanc { get; set; }
        public int CodCli { get; set; }
        public string EmailCli { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
    }
}
