using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class FindStock
    {
        public int RetCode { get; set; }
        public string RetMessage { get; set; }
        public List<Patient> PatientList { get; set; }
       
        public List<Attachments> AttachmentsList { get; set; }
    }
}
