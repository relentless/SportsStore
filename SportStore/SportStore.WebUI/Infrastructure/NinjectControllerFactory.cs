using System.Web.Mvc;
using Ninject;
using Ninject.Modules;
using System.Web.Routing;
using System;
using SportStore.Domain.Abstract;
using SportStore.Domain.Concrete;
using System.Configuration;

namespace SportStore.WebUI.Infrastructure {
    public class NinjectControllerFactory: DefaultControllerFactory {
        private IKernel kernel = new StandardKernel(new SportsStoreServices());

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType) {
            if (controllerType == null)
                return null;

            return (IController)kernel.Get(controllerType);
        }

        private class SportsStoreServices : NinjectModule {
            public override void Load() {
                Bind<IProductsRepository>()
                    .To<SqlProductsRepository>()
                    .WithConstructorArgument("connectionString",
                    ConfigurationManager.ConnectionStrings["AppDb"].ConnectionString
                    );

                Bind<IOrderProcessor>()
                    .To<FakeOrderProcessor>();
            }
        }

    }
}
