# PrismSample

Prism WPF 6.1 and Prism.Autofac

The application has three components:
- PrismWpfSample is the main application (shell)
- ToolbarModule is the module to be loaded in the main app
- PrismWpfSampleContracts is a common library with the a class for the event and an Interface for the event message to be implemented by the module

PrismWpfSample has a post build event to create a folder for the modules ("Components").
ToolbarModules has a post build event to copy the .dll to the PrismWpfSample\Compoents Debug folder

