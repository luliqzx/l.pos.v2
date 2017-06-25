using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Shipper : BaseT<string>
    {
        public virtual string Description { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string Phone { get; set; }
    }
}
