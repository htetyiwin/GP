using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class Attachments
    {
        public int Id { get; set; }
        public string FileCode { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public bool IsSaved { get; set; }
        public int IssueId { get; set; }
        public int AttachedBy { get; set; }
        public DateTime AttachedOn { get; set; }
    }
}
