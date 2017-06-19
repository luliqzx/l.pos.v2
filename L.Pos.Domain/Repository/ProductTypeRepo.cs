using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L.Core.Repositories;
using L.Pos.Model.Entity;
using L.Pos.DataAccess.Common;
using NHibernate;
using NHibernate.Linq;
using System.Collections;
using NHibernate.Criterion;

namespace L.Pos.DataAccess.Repository
{
    public interface IProductTypeRepo : IBaseRepositoryFactories<ProductType>
    {
    }
    public class ProductTypeRepo : BaseRepositoryFactories<ProductType>, IProductTypeRepo
    {
        protected IUnitOfWork _unitOfWork { get; set; }
        public ProductTypeRepo(IUnitOfWork unitOfWork)
        {
            _unitOfWork = (UnitOfWork)unitOfWork;
        }

        public override ISession Session
        {
            get
            {
                if (!_unitOfWork.Session.IsOpen)
                {
                    _unitOfWork.Session = _unitOfWork.CreateSession();
                }
                return _unitOfWork.Session;
            }
        }
    }
}
