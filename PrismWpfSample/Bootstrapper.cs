using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Prism.Autofac;
using Prism.Modularity;
using PrismWpfSample.Properties;
using PrismWpfSample.Views;

namespace PrismWpfSample
{
	public class Bootstrapper : AutofacBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}

		//protected override void ConfigureContainerBuilder(ContainerBuilder builder)
		//{
		//	base.ConfigureContainerBuilder(builder);
		//}


		protected override void ConfigureModuleCatalog()
		{
			var catalog = new DirectoryModuleCatalog
			              {
				              ModulePath = @"./Components"
			              };

			catalog.Initialize();

			foreach (var mi in catalog.Modules)
			{
				ModuleCatalog.AddModule(mi);
			}


		}

		protected override void InitializeModules()
		{
			IModuleManager manager;

			try
			{
				manager = Container.Resolve<IModuleManager>();
			}
			catch (Autofac.Core.DependencyResolutionException ex)
			{
				if (ex.Message.Contains("IModuleCatalog"))
				{
					throw new InvalidOperationException("NullModuleCatalogException");
				}
				
				throw;

			}

			manager.Run();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();

			Application.Current.MainWindow.Show();
		}
	}
}
