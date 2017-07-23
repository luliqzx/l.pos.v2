using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            //this.CompositeId()
            //    .KeyProperty(x => x.Id)
            //    .KeyReference(x => x.Client, "Client");

            this.Id(x => x.Id).GeneratedBy.Assigned();

            this.Map(x => x.Description);
            this.Map(x => x.Shortname);

            this.References(x => x.CustomerType).Columns("CustomerTypeId").Nullable().Cascade.None();

            this.HasMany(x => x.Addresses).KeyColumns.Add("CustomerId").Inverse().Cascade.AllDeleteOrphan();

            this.Map(x => x.CreateBy);
            this.Map(x => x.CreateDate).Nullable();
            this.Map(x => x.CreateTerminal);
            this.Map(x => x.UpdateBy);
            this.Map(x => x.UpdateDate).Nullable();
            this.Map(x => x.UpdateTerminal);
            this.Version(x => x.Version).CustomType<DateTime>();
        }
    }
}
