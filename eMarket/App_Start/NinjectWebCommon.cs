[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(eMarket.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(eMarket.App_Start.NinjectWebCommon), "Stop")]

namespace eMarket.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using Microsoft.AspNet.Identity;
    using eMarket.BusinessLayer.Services;
    using eMarket.Datalayer;
    using eMarket.DataLayer.Repositories;
    using eMarket.BusinessLayer;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            // TODO... either smsService or emailService ?

            kernel.Bind<IIdentityMessageService>().To<SmsService>().InRequestScope();
            kernel.Bind<IIdentityMessageService>().To<EmailService>().InRequestScope();

            //The context is called several times in the application  so we are worried about recreating 
            //the context object. DI helps us by sharing the catched copy of the context object and dispose it after every request.
            kernel.Bind<EmarketContext>().To<EmarketContext>().InRequestScope();

            kernel.Bind<IImageRepository>().To<ImageRepository>().InRequestScope();
            kernel.Bind<IProductRepository>().To<ProductRepository>().InRequestScope();
            kernel.Bind<IProductCategoryRepository>().To<ProductCategoryRepository>().InRequestScope();
        }        
    }
}
