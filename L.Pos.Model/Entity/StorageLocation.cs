using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class StorageLocation : BaseT<string>
    {
        public virtual string Description { get; set; }
        public virtual StorageType StorageType { get; set; }
        public virtual Plant Plant { get; set; }
    }
}
