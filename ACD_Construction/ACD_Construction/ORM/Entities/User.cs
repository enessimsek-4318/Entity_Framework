﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD_Construction.ORM.Entities
{
    internal class User:BaseEntity
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string userName { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public List<Document> documents { get; set; }
    }
}
