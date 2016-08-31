using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement
{
   public static class ServiceFactory
    {
        public static UserServices getService()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IUserServices, UserServices>();
            UserServices service = container.Resolve<UserServices>();
            return service;
        }
    }
}
