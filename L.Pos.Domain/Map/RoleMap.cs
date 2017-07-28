using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            this.Id(x => x.Id).Column("RoleId").GeneratedBy.Assigned();
            this.References(x => x.RootRole).Column("RootRoleId").Cascade.SaveUpdate();
            this.HasManyToMany(x => x.Employees).Table("EmployeeRole").ParentKeyColumn("RoleId").ChildKeyColumn("EmployeeId");
            this.Map(x => x.Description);

            this.HasMany(x => x.RoleMenus).KeyColumn("RoleId").Cascade.SaveUpdate().Inverse();

            #region Audit Trail

            this.Map(x => x.CreateBy);
            this.Map(x => x.CreateDate);
            this.Map(x => x.CreateTerminal);
            this.Map(x => x.UpdateBy);
            this.Map(x => x.UpdateDate);
            this.Map(x => x.UpdateTerminal);
            this.Version(x => x.Version).CustomType<int>();

            #endregion
        }
    }
}
