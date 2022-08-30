using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD_Construction.ORM.Entities
{
    internal class Register:BaseEntity
    {
        public string noıNumber { get; set; }
        public string date { get; set; }
        public string inspectionDate { get; set; }
        public int serviceOrder { get; set; }
        public string ınspectionDetails { get; set; }
        public string description { get; set; }
        public string statusOfInspection { get; set; }
        public User user { get; set; }
    }
}
