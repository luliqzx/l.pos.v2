using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Product : BaseEntity<string>
    {
        public virtual string Description { get; set; }
        public virtual string Shortname { get; set; }
        public virtual Company Company { get; set; }
        public virtual string CompanyId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual string SupplierId { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual string ProductTypeId { get; set; }

        public virtual UoM BaseUnit { get; set; }
        public virtual string BaseUnitId { get; set; }

        public virtual UoM SalesUnit { get; set; }
        public virtual string SalesUnitId { get; set; }

        //public 
    }
}
