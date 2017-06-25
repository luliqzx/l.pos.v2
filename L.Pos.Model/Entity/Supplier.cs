using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Supplier : BaseEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual string Address { get; set; }
        public virtual string City   { get; set; }
        public virtual string Region { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string Country { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string HomePage { get; set; }
        public virtual Company Company { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Supplier ent = obj as Supplier;
                if (Id == ent.Id && Company == ent.Company)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (Id + "|" + Company.Id).GetHashCode();
            return i;
        }
    }
}
