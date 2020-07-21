using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class FtpServer
    {
        public int Id { get; set; }
        public string ServerAddress { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool Active { get; set; }
    }
}
