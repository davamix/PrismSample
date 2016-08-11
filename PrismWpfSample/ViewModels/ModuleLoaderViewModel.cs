using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismWpfSample.ViewModels
{
	public class ModuleLoaderViewModel:BindableBase
	{
		private readonly IModuleManager _moduleManager;
		private readonly IModuleCatalog _moduleCatalog;
		private readonly IRegionManager _regionManager;

		public ObservableCollection<ModuleInfo> Modules { get; set; }
		public ICommand LoadModuleCommand { get; set; }
		public CompositeCommand InitializeModuleCommand { get; set; }
		public ICommand UnloadModulesCommand { get; set; }

		public ModuleLoaderViewModel(IModuleManager moduleManager, IModuleCatalog moduleCatalog, IRegionManager regionManager)
		{
			_moduleManager = moduleManager;
			_moduleCatalog = moduleCatalog;
			_regionManager = regionManager;

			LoadModuleCommand = new DelegateCommand<string>(LoadModule);
			UnloadModulesCommand = new DelegateCommand(UnloadModules);

			InitializeModuleCommand = new CompositeCommand();
			InitializeModuleCommand.RegisterCommand(UnloadModulesCommand);
			InitializeModuleCommand.RegisterCommand(LoadModuleCommand);

			Modules = new ObservableCollection<ModuleInfo>(_moduleCatalog.Modules);
			
		}

		private void UnloadModules()
		{
			foreach (var module in _moduleCatalog.Modules)
			{
				module.State = ModuleState.NotStarted;
				
			}
			_regionManager.Regions["ToolbarRegion"].RemoveAll();
			//_regionManager.Regions["ToolbarRegion"].ActiveViews.First();
		}

		private void LoadModule(string moduleName)
		{
			var module = _moduleCatalog.Modules.FirstOrDefault(x=>x.ModuleName.Equals(moduleName));
			
			if(module?.State == ModuleState.NotStarted)
				_moduleManager.LoadModule(moduleName);
		}
	}
}
