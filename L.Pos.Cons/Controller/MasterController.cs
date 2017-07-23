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
        void collectclient();
        void buildcustomer();
        void collectsupplier();
        void collectuom();
        void collectproduct();
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
            Client client = UnitOfWork.CreateSession().Load<Client>("0001");

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
                    ProductType pt = this.UnitOfWork.Session.Query<ProductType>().FirstOrDefault(x => x.Id == lstPT[i].Id );
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
            Client client = this.UnitOfWork.CreateSession().Load<Client>("0001");

            IList<CustomerType> lstCT = new List<CustomerType>();
            lstCT.Add(new CustomerType { Id = "Umum", Description = "Umum"});
            lstCT.Add(new CustomerType { Id = "Toko", Description = "Toko"});

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

        public void collectclient()
        {
            Client cp = this.UnitOfWork.Session.Query<Client>().FirstOrDefault(x => x.Id == "0001");
            if (cp == null)
            {
                cp = new Client { Id = "0001", Description = "My Shop", CreateDate = DateTime.Now, UpdateDate = DateTime.Now };
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
                Client cp = sess.Query<Client>().FirstOrDefault(x => x.Id == "0001");

                Customer cust = new Customer();
                cust.Id = "CustUmum1";
                //cust.Client = cp;
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
                Client cp = sess.Query<Client>().FirstOrDefault(x => x.Id == "0001");

                Customer cust = sess.Query<Customer>().FirstOrDefault(x => x.Id == "CustUmum1");

                using (ITransaction trx = sess.BeginTransaction())
                {
                    if (cust.Addresses == null)
                    {
                        cust.Addresses = new List<Address>();
                    }
                    cust.Addresses.Clear();

                    Address addr = sess.Query<Address>().FirstOrDefault(x => x.Id == "Rumah" && x.Customer == cust);
                    if (addr == null)
                    {
                        cust.Addresses.Add(new Address { Id = "Rumah", Customer = cust, Person = "Lucky", AddressLine = "Bekasi", CreateDate = DateTime.Now, UpdateDate = DateTime.Now });
                    }

                    sess.Update(cust);
                    trx.Commit();
                }
            }
        }

        public void collectsupplier()
        {
            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                Supplier supp1 = sess.Query<Supplier>().FirstOrDefault(x => x.Id == "Amigos");
                if (supp1 == null)
                {
                    supp1 = new Supplier();
                    supp1.Id = "Amigos";
                    supp1.Description = "Amigos";
                    //supp1.Client = this.UnitOfWork.Session.Query<Client>().FirstOrDefault(x => x.Id == "0001");
                    using (ITransaction trx = sess.BeginTransaction())
                    {
                        sess.Save(supp1);
                        trx.Commit();
                    }
                }
            }
            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                Supplier supp2 = sess.Query<Supplier>().FirstOrDefault(x => x.Id == "Summo");
                if (supp2 == null)
                {
                    supp2 = new Supplier();
                    supp2.Id = "Summo";
                    supp2.Description = "Summo";
                    //supp2.Client = this.UnitOfWork.Session.Query<Client>().FirstOrDefault(x => x.Id == "0001");
                    using (ITransaction trx = sess.BeginTransaction())
                    {
                        sess.Save(supp2);
                        trx.Commit();
                    }
                }
            }
        }

        public void collectuom()
        {
            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                using (ITransaction trx = sess.BeginTransaction())
                {
                    UoM UoM1 = sess.Query<UoM>().FirstOrDefault(x => x.Id == "PCS");
                    if (UoM1 == null)
                    {
                        UoM1 = new UoM();
                        UoM1.Id = "PCS";
                        UoM1.Description = "PCS";
                        UoM1.Active = true;
                        sess.Save(UoM1);
                    }

                    UoM UoM2 = sess.Query<UoM>().FirstOrDefault(x => x.Id == "PACK");
                    if (UoM2 == null)
                    {
                        UoM2 = new UoM();
                        UoM2.Id = "PACK";
                        UoM2.Description = "PACK";
                        UoM2.Active = true;
                        sess.Save(UoM2);
                    }
                    trx.Commit();
                }
            }
        }

        public void collectproduct()
        {
            using (ISession sess = this.UnitOfWork.CreateSession())
            {
                using (ITransaction trx = sess.BeginTransaction())
                {
                    Product Product1 = sess.Query<Product>().FirstOrDefault(x => x.Id == "TESPROD01");
                    if (Product1 == null)
                    {
                        Product1 = new Product();
                        Product1.Id = "TESPROD01";
                        Product1.Description = "TESPROD01";
                        Product1.BaseUnit = sess.Load<UoM>("PCS");
                        Product1.SalesUnit = sess.Load<UoM>("PCS");
                        Product1.Shortname = "TESPROD01";
                        Product1.CreateDate = DateTime.Now;
                        Product1.UpdateDate = DateTime.Now;
                        //Product1.Client = sess.Load<Client>("0001");
                        //Product1.Supplier = sess.Load<Supplier>(new Supplier { Id = "Summo", Client = Product1.Client });
                        //Product1.Supplier = sess.Query<Supplier>().FirstOrDefault(x => x.Id == "0001" && (x.Company != null && x.Company.Id == "0001"));
                        sess.Save(Product1);
                    }
                    trx.Commit();
                }
            }
        }
    }
}
