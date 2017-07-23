using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class CustomerTypeMap : ClassMap<CustomerType>
    {
        public CustomerTypeMap()
        {
            //this.CompositeId().KeyProperty(x => x.Id).KeyReference(x => x.Client, "Client");
            this.Id(x => x.Id).GeneratedBy.Assigned();
            this.Map(x => x.Description);
        }
    }
}
