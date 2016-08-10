using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;
using ToolbarModule.Views;

namespace ToolbarModule
{
    public class ToolbarModule:IModule
    {
	    private readonly IRegionManager _regionManager;

	    public ToolbarModule(IRegionManager regionManager)
	    {
		    _regionManager = regionManager;
	    }

	    public void Initialize()
	    {
		    _regionManager.RegisterViewWithRegion("ToolbarRegion", typeof(ToolbarView));
	    }
    }
}
