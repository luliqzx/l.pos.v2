using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class ProductType : BaseT<string>
    {
        public virtual string Description { get; set; }
        public virtual Client Client { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                ProductType ent = obj as ProductType;
                if (ent.Client == this.Client && ent.Id == this.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            int i = 0;
            i = (this.Id).GetHashCode() + (this.Client).GetHashCode();
            return i;
        }
    }
}
