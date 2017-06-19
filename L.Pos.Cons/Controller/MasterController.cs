using L.Pos.DataAccess.Common;
using L.Pos.Model.Entity;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace L.Pos.Cons.Controller
{
    public interface IMasterController
    {
        void collectproducttype();
        void collectcustomertype();
        void collectcompany();
        void buildcustomer();
    }
    public class MasterController : IMasterController
    {
        private IUnitOfWork UnitOfWork { get; set; }

        public MasterController(IUnitOfWork _UnitOfWork)
        {
            this.UnitOfWork = _UnitOfWork;
        }

        public void collectproducttype()
        {
            IList<ProductType> lstPT = new List<ProductType>();
            lstPT.Add(new ProductType { Id = "Makanan", Description = "Makanan" });
            lstPT.Add(new ProductType { Id = "Minuman", Description = "Minuman" });
            lstPT.Add(new ProductType { Id = "Pakaian", Description = "Pakaian" });
            lstPT.Add(new ProductType { Id = "Sepatu", Description = "Sepatu" });
            lstPT.Add(new ProductType { Id = "Tas", Description = "Tas" });

            using (ITransaction trx = this.UnitOfWork.Session.BeginTransaction())
            {
                for (int i = 0; i < lstPT.Count; i++)
                {
                    ProductType pt = this.UnitOfWork.Session.Query<ProductType>().FirstOrDefault(x => x.Id == lstPT[i].Id);
                    if (pt == null)
                    {
                        this.UnitOfWork.Session.Save(lstPT[i]);
                    }
                }
                trx.Commit();
            }

        }

        public void collectcustomertype()
        {
            IList<CustomerType> lstCT = new List<CustomerType>();
            lstCT.Add(new CustomerType { Id = "Umum", Description = "Umum" });
            lstCT.Add(new CustomerType { Id = "Toko", Description = "Toko" });

            using (ITransaction trx = this.UnitOfWork.Session.BeginTransaction())
            {
                for (int i = 0; i < lstCT.Count; i++)
                {
                    CustomerType ct = this.UnitOfWork.Session.Query<CustomerType>().FirstOrDefault(x => x.Id == lstCT[i].Id);
                    if (ct == null)
                    {
                        this.UnitOfWork.Session.Save(lstCT[i]);
                    }
                }
                trx.Commit();
            }

        }

        public void collectcompany()
        {
            Company cp = this.UnitOfWork.Session.Query<Company>().FirstOrDefault(x => x.Id == "0001");
            if (cp == null)
            {
                cp = new Company { Id = "0001", Description = "My Shop", CreateDate = DateTime.Now, UpdateDate = DateTime.Now };
                using (ISession sess = this.UnitOfWork.Session)
                {
                    using (ITransaction trx = sess.BeginTransaction())
                    {
                        sess.Save(cp);
                        trx.Commit();
                    }
                }
            }
            else
            {
                using (ISession sess = this.UnitOfWork.Session)
                {
                    using (ITransaction trx = sess.BeginTransaction())
                    {
                        cp.UpdateDate = DateTime.Now;
                        sess.Update(cp);
                        trx.Commit();
                    }
                }
            }
        }

        public void buildcustomer()
        {
            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                CustomerType ct = sess.Query<CustomerType>().FirstOrDefault(x => x.Id == "Umum");
                Company cp = sess.Query<Company>().FirstOrDefault(x => x.Id == "0001");

                Customer cust = new Customer();
                cust.Id = "CustUmum1";
                cust.Company = cp;
                cust.CustomerType = ct;
                cust.CreateDate = DateTime.Now;
                cust.UpdateDate = DateTime.Now;
                cust.Description = "Umum 1";
                cust.Shortname = "Umum 1";

                Customer custVerify = sess.Query<Customer>().FirstOrDefault(x => x.Id == "CustUmum1");
                if (custVerify == null)
                {
                    using (ITransaction trx = sess.BeginTransaction())
                    {
                        sess.Save(cust);
                        trx.Commit();
                    }    
                }
            }

            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                CustomerType ct = sess.Query<CustomerType>().FirstOrDefault(x => x.Id == "Umum");
                Company cp = sess.Query<Company>().FirstOrDefault(x => x.Id == "0001");

                Customer cust = sess.Query<Customer>().FirstOrDefault(x => x.Id == "CustUmum1");

                using (ITransaction trx = sess.BeginTransaction())
                {
                    if (cust.Addresses == null)
                    {
                        cust.Addresses = new List<Address>();
                    }
                    cust.Addresses.Clear();

                    cust.Addresses.Add(new Address { Id = "Rumah", Customer = cust, Person = "Lucky", AddressLine = "Bekasi", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });

                    sess.SaveOrUpdate(cust);
                    trx.Commit();
                }
            }
        }
    }
}
