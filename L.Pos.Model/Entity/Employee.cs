using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Model.Entity
{
    public class Employee : BaseEntity<string>
    {
        public virtual string Firstname { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Nickname { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual Company Company { get; set; }
        public virtual string CompanyId { get; set; }
        public virtual IList<Company> Companies { get; set; }
    }
}
