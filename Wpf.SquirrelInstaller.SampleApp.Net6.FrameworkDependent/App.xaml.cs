using Squirrel;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wpf.SquirrelInstaller.SampleApp.Net6.FrameworkDependent
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // run Squirrel first, as the app may exit after these run
            SquirrelAwareApp.HandleEvents(
                onInitialInstall: OnAppInstall,
                onAppUninstall: OnAppUninstall,
                onEveryRun: OnAppRun);

            base.OnStartup(e);
        }

        private static void OnAppInstall(SemanticVersion version, IAppTools tools)
        {
            tools.CreateShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
        }

        private static void OnAppUninstall(SemanticVersion version, IAppTools tools)
        {
            tools.RemoveShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
        }

        private static void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
        {
            tools.SetProcessAppUserModelId();
            // show a welcome message when the app is first installed
            if (firstRun) MessageBox.Show("Thanks for installing my application!");
        }
    }
}
