using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            this.CompositeId()
                .KeyProperty(x => x.Id)
                .KeyReference(x => x.Client, "ClientId");
            this.Map(x => x.Description);
            this.Map(x => x.Shortname);

            this.References(x => x.Supplier).Columns("SupplierId", "ClientId");//.Cascade.None();
            this.References(x => x.ProductType).Columns("ProductTypeId", "ClientId");//.Cascade.None();
            this.References(x => x.BaseUnit, "BaseUnitId");//.Cascade.None();
            this.References(x => x.SalesUnit, "SalesUnitId");//.Cascade.None();
        }
    }
}
