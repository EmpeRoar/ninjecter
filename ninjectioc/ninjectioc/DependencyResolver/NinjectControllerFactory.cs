﻿using Ninject;
using ninjectioc.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ninjectioc.DependencyResolver
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IBook>().To<BookEF>().InSingletonScope();
            
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}