using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class AddressMap : ClassMap<Address>
    {
        public AddressMap()
        {
            this.CompositeId()
                .KeyProperty(x => x.Id, "AddressId")
                .KeyReference(x => x.Customer, "Id", "CompanyId");

            this.Map(x => x.Person);
            this.Map(x => x.AddressLine);
            this.Map(x => x.City);
            this.Map(x => x.Province);
            this.Map(x => x.Country);

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
