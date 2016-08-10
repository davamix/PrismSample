using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using Prism.Mvvm;
using PrismWpfSample.Events;
using PrismWpfSampleContracts.Events;

namespace PrismWpfSample.ViewModels
{
	public class ContentViewModel : BindableBase
	{
		private readonly IEventAggregator _eventAggregator;

		//private string _contentValue;
		//public string ContentValue
		//{
		//	get { return _contentValue; }
		//	set { SetProperty(ref _contentValue, value); }

		//}

		private ObservableCollection<string> _contentValues;
		public ObservableCollection<string> ContentValues
		{
			get { return _contentValues; }
			set { SetProperty(ref _contentValues, value); }
		}

		public ContentViewModel(IEventAggregator eventAggregator)
		{
			_eventAggregator = eventAggregator;
			_contentValues = new ObservableCollection<string>();

			//_eventAggregator.GetEvent<ToolbarButtonEvent>().Subscribe((x) => ContentValue = $"[{x.Id}] - {x.Message}");

			//_eventAggregator.GetEvent<ToolbarButtonEvent>().Subscribe((x) => ContentValues.Add($"[{x.Id}] - {x.Message}"));
			_eventAggregator.GetEvent<ToolbarButtonEvent>().Subscribe((x) => ContentValues.Add($"[{x.Id}] - {x.Message}"));
		}
	}
}
