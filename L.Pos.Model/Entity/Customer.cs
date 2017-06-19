using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L.Pos.Model.Entity
{
    public class Customer : BaseEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual string Shortname { get; set; }
        public virtual Company Company { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual IList<Address> Addresses { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Customer ent = obj as Customer;
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
