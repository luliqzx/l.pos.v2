using FluentNHibernate.Mapping;
using L.Pos.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.DataAccess.Map
{
  public  class SupplierMap:ClassMap<Supplier>
    {
      public SupplierMap()
      {
          this.CompositeId()
              .KeyProperty(x => x.Id)
              .KeyReference(x => x.Company, "CompanyId");
          this.Map(x => x.Description);
      }
    }
}
