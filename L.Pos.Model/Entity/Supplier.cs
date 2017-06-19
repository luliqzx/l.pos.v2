using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Supplier : BaseEntity<string>
    {
        public virtual string SupplierName { get; set; }
        public virtual Company Company { get; set; }
        public virtual string CompanyId { get; set; }
    }
}
