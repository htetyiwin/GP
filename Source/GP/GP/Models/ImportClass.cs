using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class ImportClass
    {
        public string receive { get; set; }

        public string file { get; set; }

        public IFormFile picture;
    }
}
