using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIAP.Models
{
    public class LoginModel
    {
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string SALT { get; set; }
        public bool ADMIN { get; set; }
    }
}
