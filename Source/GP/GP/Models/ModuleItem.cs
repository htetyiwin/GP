using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GP.Models
{
    public class ModuleItem
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public bool Allowed { get; set; }
        public string GroupCode { get; set; }
        public int Order { get; set; }
        public string LinkText { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string IconClass { get; set; }
    }
}
