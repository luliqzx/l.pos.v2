using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            this.Id(x => x.Id).GeneratedBy.Assigned();
            this.Map(x => x.Username).Unique();
            this.Map(x => x.Password);
            this.Map(x => x.Firstname);
            this.Map(x => x.MiddleName);
            this.Map(x => x.LastName);

            this.HasManyToMany(x => x.Roles).Table("EmployeeRole").ParentKeyColumn("EmployeeId").ChildKeyColumn("RoleId").AsBag();

            #region Audit Trail

            this.Map(x => x.CreateBy);
            this.Map(x => x.CreateDate);
            this.Map(x => x.CreateTerminal);
            this.Map(x => x.UpdateBy);
            this.Map(x => x.UpdateDate);
            this.Map(x => x.UpdateTerminal);
            this.Version(x => x.Version).CustomType<DateTime>();

            #endregion
        }
    }
}
