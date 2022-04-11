# WpfSquirrelInstallerSamples
Simple WPF applications to show different squirrel installers in action


## How to create installation packages for Wpf.SquirrelInstaller.SampleApp.NetFullFramework
In Package Manager Console from the `WpfSquirrelInstallerSamples\Wpf.SquirrelInstaller.SampleApp.NetFullFramework` directory run the following commands

```
.\nuget.exe pack 
squirrel --releasify .\WpfSampleAppFullFramework.1.0.0.nupkg -r FullFramework
```


## How to create installation packages for Wpf.SquirrelInstaller.SampleApp.Net6
In Package Manager Console from the `WpfSquirrelInstallerSamples\Wpf.SquirrelInstaller.SampleApp.Net6` directory run the following commands

```
Set-Alias ClowdSquirrel ($env:USERPROFILE + "\.nuget\packages\clowd.squirrel\2.8.40\tools\Squirrel.exe");
# build / publish your app, csproj settings make this a self-contained single file application
dotnet publish -c Release -o ".\publish" 
ClowdSquirrel pack --packId "YourApp" --packVersion "1.0.0" --packAuthors "Mark Burton" --packDirectory ".\publish"
```
