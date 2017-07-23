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
        //public virtual Client Client { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ProductType ProductType { get; set; }

        public virtual UoM BaseUnit { get; set; }

        public virtual UoM SalesUnit { get; set; }
<<<<<<< HEAD

        public virtual decimal PriceUnit { get; set; }


        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Product ent = obj as Product;
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
=======
>>>>>>> a5a64c71d289a609bff77d33387b288a84fe7f63
    }
}
