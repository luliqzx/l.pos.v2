using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class PrivilegeMap : ClassMap<Privilege>
    {
        public PrivilegeMap()
        {
            this.Id(x => x.Id).Column("PrivilegeId").GeneratedBy.Assigned();
            this.Map(x => x.Description);
            this.Map(x => x.Active);

            this.HasManyToMany(x => x.RoleMenus).Table("RoleMenuPrivilege").ChildKeyColumns.Add("RoleId", "MenuId").ParentKeyColumn("PrivilegeId");
        }
    }
}
