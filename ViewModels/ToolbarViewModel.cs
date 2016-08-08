using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismWpfSample.Events;

namespace PrismWpfSample.ViewModels
{
	public class ToolbarViewModel : BindableBase
	{
		private readonly IEventAggregator _eventAggregator;
		public ICommand ButtonACommand { get; set; }
		public ICommand ButtonBCommand { get; set; }
		public ICommand ButtonCCommand { get; set; }
		public ICommand ButtonDCommand { get; set; }

		public ToolbarViewModel(IEventAggregator eventAggregator)
		{
			_eventAggregator = eventAggregator;

			ButtonACommand = new DelegateCommand<string>(Notify); // From CommandParameter
			ButtonBCommand = new DelegateCommand<string>(Notify); // From CommandParameter
			ButtonCCommand = new DelegateCommand(() => Notify("Hello Button C"));
			ButtonDCommand = new DelegateCommand(() => Notify("Hello Button D"));
		}

		private void Notify(string message)
		{
			var buttonMessage = new ToolbarButtonEventMessage
			                    {
				                    Id = Guid.NewGuid().ToString(),
				                    Message = message
			                    };

			_eventAggregator.GetEvent<ToolbarButtonEvent>().Publish(buttonMessage);
		}
	}
}
