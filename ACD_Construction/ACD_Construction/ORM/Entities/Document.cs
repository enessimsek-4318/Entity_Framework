using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD_Construction.ORM.Entities
{
    internal class Document:BaseEntity
    {
        public string docOrginator { get; set; }
        public string docType { get; set; }
        public string docDisipline { get; set; }
        public string locationArea { get; set; }
        public string documentNumber { get; set; }
        public string documentTitle { get; set; }
        public string revision { get; set; }
        public string sendingReason { get; set; }
        public string documentStatus { get; set; }
        public string transNoTo { get; set; }
        public string transNoFrom { get; set; }
        public string serviceOrderNo { get; set; }
        //Primary Key
        public int userID { get; set; }
        public User user { get; set; }
    }
}
