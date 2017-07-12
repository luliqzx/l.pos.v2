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
        public virtual Client Client { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public virtual IList<Address> Addresses { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Customer ent = obj as Customer;
                if (Id == ent.Id && Client == ent.Client)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (Id + "|" + Client.Id).GetHashCode();
            return i;
        }
    }
}
