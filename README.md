# Prism Sample

Prism WPF 6.2 and Prism.Autofac

The application has three components:
- PrismWpfSample is the main application (shell) (The solution file is here)
- ToolbarModule is the module to be loaded in the main app
- PrismWpfSampleContracts is a common library with a class for the event and an Interface for the event message to be implemented by the module

PrismWpfSample has a post build event to create a folder for the modules ("Components").
ToolbarModules has a post build event to copy the .dll to the PrismWpfSample\Components Debug folder

If you run the app before build the solution only the main window shown, so it works without error when the module is not ready :) Build the solution in order to create the module and run the post build events.

https://github.com/PrismLibrary/Prism

