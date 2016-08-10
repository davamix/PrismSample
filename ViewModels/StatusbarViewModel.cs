using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismWpfSample.ViewModels
{
	public class StatusbarViewModel :BindableBase
	{
		private bool _isOnline;

		public bool IsOnline
		{
			get { return _isOnline; }
			set { SetProperty(ref _isOnline, value); }
		}

		public StatusbarViewModel()
		{
			Task.Run(() =>
			{
				while (true)
				{
					Thread.Sleep(1000);
					IsOnline = !IsOnline;
				}
			});


		}
	}
}
