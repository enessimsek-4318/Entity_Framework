using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACD_Construction.ORM.Entities
{
    internal class BaseEntity
    {
        public int ID { get; set; }
        private DateTime? _addDate = DateTime.Now;
        public DateTime? AddDate { get { return _addDate; } set { _addDate = value; } }
        private DateTime? _updateDate = DateTime.Now;
        public DateTime? UpdateDate
        {
            get { return _updateDate; }
            set { _updateDate = value; }
        }
        //private DateTime? _deletedDate = DateTime.Now;
        //public DateTime? DeletedDate { get { return _deletedDate; } set { _deletedDate = value; } }

        //private bool _isDeleted = false;
        //public bool IsDeleted { get { return _isDeleted; } set { _isDeleted = value; } }
    }
}
