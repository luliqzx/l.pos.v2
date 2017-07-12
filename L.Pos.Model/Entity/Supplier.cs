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
        public virtual Client Client { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                Supplier ent = obj as Supplier;
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
