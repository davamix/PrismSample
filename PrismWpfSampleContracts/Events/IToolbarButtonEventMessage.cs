using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWpfSampleContracts.Events
{
	public interface IToolbarButtonEventMessage
	{
		string Id { get; set; }
		string Message { get; set; }
	}
}
