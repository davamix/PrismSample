using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;
using PrismWpfSampleContracts.Events;

namespace PrismWpfSample.Events
{
	public class ToolbarButtonEventMessage :IToolbarButtonEventMessage
	{
		public string Id { get; set; }
		public string Message { get; set; }
	}
}
