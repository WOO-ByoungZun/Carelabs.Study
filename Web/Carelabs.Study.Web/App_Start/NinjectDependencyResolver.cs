using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using System.Web.Mvc;
using Ninject;

namespace Carelabs.Study.Web.App_Start
{
    public class NinjectDependencyResolver : System.Web.Mvc.IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }

        public IKernel GetKernel()
        {
            return _kernel;
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Carelabs.Study.Repository.Dummy.Module m = new Repository.Dummy.Module(_kernel);
            m.Initialize();

        }

    }
}