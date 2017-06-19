﻿using L.Pos.DataAccess.Common;
using L.Pos.Model.Entity;
//using L.Pos.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using NHibernate;

namespace L.Pos.Cons.Controller
{
    public interface IActorController
    {
        void Create();
        void Update();
        void Delete();
        void Read();
    }

    public class ActorController : IActorController
    {
        //private IActorRepository ActRepo { get; set; }
        //private IUnitOfWork UnitOfWork { get; set; }

        //public ActorController(IUnitOfWork _UnitOfWork, IActorRepository _ActRepo)
        //{
        //    this.ActRepo = _ActRepo;
        //    this.UnitOfWork = _UnitOfWork;
        //}

        public void Create()
        {
            //    Actor parent1 = this.ActRepo.Session.Query<Actor>().FirstOrDefault(x => x.Id == "Par1");
            //    if (parent1 == null)
            //    {
            //        parent1 = new Actor();

            //        parent1.Id = "Par1";
            //        parent1.CreateDate = DateTime.Now;
            //        parent1.UpdateDate = DateTime.Now;
            //        parent1.Active = true;
            //        parent1.Description = "Par1";
            //        this.UnitOfWork.BeginTransaction();
            //        this.ActRepo.Save(parent1);
            //        this.UnitOfWork.Commit();
            //    }

            //    Role roleAdmin = this.UnitOfWork.CreateSession().Query<Role>().FirstOrDefault(x => x.Id == "Admin");
            //    if (roleAdmin == null)
            //    {
            //        roleAdmin = new Role();
            //        roleAdmin.Id = "Admin";
            //        roleAdmin.Description = "Admin Role";
            //        roleAdmin.CreateDate = DateTime.Now;
            //        roleAdmin.UpdateDate = DateTime.Now;

            //        roleAdmin.AddActor(parent1);

            //        this.UnitOfWork.BeginTransaction();
            //        this.UnitOfWork.Session.Save(roleAdmin);
            //        this.UnitOfWork.Commit();
            //    }

            //    Actor Actor = new Actor();
            //    Actor.Id = "001";
            //    Actor.CreateDate = DateTime.Now;
            //    Actor.UpdateDate = DateTime.Now;
            //    Actor.Active = true;
            //    Actor.Description = "test";
            //    Actor.SetMain(parent1);
            //    Actor.ActorType = ActorType.User;

            //    Profile prof = new Profile();
            //    prof.Username = "Employee 001";
            //    prof.Address = "Gang";
            //    prof.CreateDate = DateTime.Now;
            //    prof.UpdateDate = DateTime.Now;
            //    prof.Email = "TEST";
            //    //prof.SetActor(Actor);
            //    Actor.SetProfile(prof);

            //    OtherAddress othAddr = new OtherAddress();
            //    othAddr.Address = "TEST";
            //    othAddr.Id = "TEST";
            //    othAddr.Actor = Actor;
            //    othAddr.CreateDate = DateTime.Now;
            //    othAddr.UpdateDate = DateTime.Now;
            //    Actor.AddNewAddress(othAddr);

            //    Menu menu = this.UnitOfWork.CreateSession().Query<Menu>().FirstOrDefault(x => x.Id == "DefaultMenu");
            //    if (menu == null)
            //    {
            //        menu = new Menu();
            //        menu.Id = "DefaultMenu";
            //        menu.Description = "DefaultMenu";
            //        menu.CreateDate = DateTime.Now;
            //        menu.UpdateDate = DateTime.Now;
            //        menu.Position = 1;

            //        this.UnitOfWork.BeginTransaction();
            //        this.UnitOfWork.Session.Save(menu);
            //        this.UnitOfWork.Commit();
            //    }

            //    Role role = this.UnitOfWork.CreateSession().Query<Role>().FirstOrDefault(x => x.Id == "User");
            //    if (role == null)
            //    {
            //        role = new Role();
            //        role.Id = "User";
            //        role.Description = "User Role";
            //        role.CreateDate = DateTime.Now;
            //        role.UpdateDate = DateTime.Now;
            //        this.UnitOfWork.BeginTransaction();
            //        this.UnitOfWork.Session.Save(role);
            //        this.UnitOfWork.Commit();
            //    }

            //    RoleMenu rm = this.UnitOfWork.CreateSession().Query<RoleMenu>().FirstOrDefault(x => x.Role == role && x.Menu == menu);
            //    if (rm == null)
            //    {
            //        rm = new RoleMenu();
            //        rm.Role = role;
            //        rm.Menu = menu;
            //        rm.Active = true;
            //        this.UnitOfWork.BeginTransaction();
            //        this.UnitOfWork.Session.Save(rm);
            //        this.UnitOfWork.Commit();
            //    }
            //    else
            //    {
            //        rm.Privileges.Clear();
            //        for (int i = 0; i < 10; i++)
            //        {
            //            Privilege priv = new Privilege();
            //            priv.Id = "test" + (i + 1);
            //            priv.Description = "test" + (i + 1);
            //            priv.CreateDate = DateTime.Now;
            //            priv.UpdateDate = DateTime.Now;

            //            //this.UnitOfWork.BeginTransaction();
            //            this.UnitOfWork.Session.Save(priv);
            //            //this.UnitOfWork.Commit();

            //            rm.Privileges.Add(priv);
            //        }

            //        this.UnitOfWork.BeginTransaction();
            //        this.UnitOfWork.Session.SaveOrUpdate(rm);
            //        this.UnitOfWork.Commit();
            //    }
            //    role.AddRoleMenu(rm);
            //    Actor.AddRole(role);

            //    this.UnitOfWork.BeginTransaction();
            //    this.ActRepo.Save(Actor);
            //    this.UnitOfWork.Commit();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            //Actor Actor = this.ActRepo.Session.Query<Actor>().FirstOrDefault(x => x.Id == "001");
            //if (Actor != null)
            //{
            //    this.UnitOfWork.BeginTransaction();
            //    this.ActRepo.Delete(Actor);
            //    this.UnitOfWork.Commit();
            //}
        }

        public void Read()
        {

        }
    }
}
