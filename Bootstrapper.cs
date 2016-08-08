using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using Prism.Autofac;
using PrismWpfSample.Views;

namespace PrismWpfSample
{
	public class Bootstrapper : AutofacBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.Resolve<MainWindow>();
		}

		protected override void InitializeShell()
		{
			base.InitializeShell();

			Application.Current.MainWindow.Show();
		}
	}
}
