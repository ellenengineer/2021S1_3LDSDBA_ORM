using System;
using System.Collections.Generic;

#nullable disable

namespace INFONEW_API.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Login1 { get; set; }
        public string Senha { get; set; }
        public int CodCli { get; set; }

        public virtual Cliente CodCliNavigation { get; set; }
    }
}
