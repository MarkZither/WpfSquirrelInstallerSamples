# WpfSquirrelInstallerSamples
Simple WPF applications to show different squirrel installers in action


## How to create installation packages for Wpf.SquirrelInstaller.SampleApp.NetFullFramework
In Package Manager Console from the `WpfSquirrelInstallerSamples\Wpf.SquirrelInstaller.SampleApp.NetFullFramework` directory run the following commands

```
.\nuget.exe pack 
squirrel --releasify .\WpfSampleAppFullFramework.1.0.0.nupkg -r FullFramework
```