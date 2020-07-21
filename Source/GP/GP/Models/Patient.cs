using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        public string PatientCode { get; set; }

        public string PatientName { get; set; }

        public string Patient_Code { get; set; }

        public string Patient_Name { get; set; }

        public int FileID { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string Address { get; set; }
        
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public int GenderID { get; set; }

        public int Gender_ID { get; set; }

        public string GenderCode { get; set; }

        public string GenderName { get; set; }

        public int Created_By { get; set; }

        public DateTime Created_On { get; set; }

        public int Modified_By { get; set; }

        public DateTime Modified_On { get; set; }

        public bool Active { get; set; }
    }
}
