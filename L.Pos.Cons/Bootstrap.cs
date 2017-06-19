﻿using L.Core.Utilities;
using L.Pos.Cons.Controller;
using L.Pos.DataAccess.Common;
//using L.Pos.DataAccess.Repository;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Pos.Cons
{
    class Bootstrap
    {
        public static void Start(Container container)
        {
            try
            {
                // 1. Create a new Simple Injector container

                // 2. Configure the container (register)
                container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);
                container.Register<IMasterController, MasterController>(Lifestyle.Singleton);
                //container.Register<IActorController, ActorController>(Lifestyle.Singleton);
                //container.Register<ITestController, TestController>(Lifestyle.Singleton);
                //container.Register<IActorRepository, ActorRepository>(Lifestyle.Singleton);
                //container.Register<ICountRepository, CountRepository>(Lifestyle.Singleton);
                //container.Register<IPrivilegeRepository, PrivilegeRepository>(Lifestyle.Singleton);
                //container.Register<IDefaultFacade, CounterFacade>(Lifestyle.Singleton);

                // 3. Optionally verify the container's configuration.
                container.Verify();
            }
            catch (Exception ex)
            {
                string errMsg = ex.GetFullMessage();
            }


        }
    }
}
