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
        public virtual CustomerType CustomerType { get; set; }
        public virtual Plant BasePlant { get; set; }
        public virtual IList<Address> Addresses { get; set; }
    }
}
