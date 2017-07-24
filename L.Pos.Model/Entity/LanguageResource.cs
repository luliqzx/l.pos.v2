using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class LanguageResource : BaseEntity<string>
    {
        public virtual Language Language { get; set; }
        public virtual string LanguageKey { get; set; }
        public virtual string LanguageValue { get; set; }
    }
}
