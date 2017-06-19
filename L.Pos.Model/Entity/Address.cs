using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Address : BaseEntity<string>
    {
        //public virtual string AddressName { get; set; }
        public virtual string Person { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual string AddressLine { get; set; }
        public virtual string City { get; set; }
        public virtual string Province { get; set; }
        public virtual string Country { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Address ent = obj as Address;
                if (Id == ent.Id && Customer == ent.Customer)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (Id + "|" + Customer.Id + "|" + Customer.Company.Id).GetHashCode();
            return i;
        }
    }
}
