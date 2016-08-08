using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Events;

namespace PrismWpfSample.Events
{
	public class ToolbarButtonEventMessage
	{
		public string Id { get; set; }
		public string Message { get; set; }
	}
}
