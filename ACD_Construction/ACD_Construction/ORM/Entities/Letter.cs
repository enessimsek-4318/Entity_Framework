using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD_Construction.ORM.Entities
{
    internal class Letter:BaseEntity
    {
        public string correspondenceNo { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string subject { get; set; }
        public bool attachment { get; set; } // it will be  hold boolen structure on the database, because letters have attachment or no attachment 
        public string date { get; set; }
        public string answer { get; set; }
        public string response { get; set; }
        public string referenceLetter { get; set; }
        public User user { get; set; }
    }
}
