using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;
using Toolbar2Module.Views;

namespace Toolbar2Module
{
	[Module(OnDemand = true)]
    public class Toolbar2Module :IModule
    {
	    private readonly IRegionManager _regionManager;

	    public Toolbar2Module(IRegionManager regionManager)
	    {
		    _regionManager = regionManager;
	    }

	    public void Initialize()
	    {
		    _regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(Toolbar2View));
	    }
    }
}
