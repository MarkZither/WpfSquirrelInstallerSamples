using Squirrel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2FullFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var updateManager = new UpdateManager(@"https://raw.githubusercontent.com/MarkZither/WpfSquirrelInstallerSamples/trunk/Wpf.SquirrelInstaller.SampleApp.NetFullFramework/FullFramework/"))
                {
                    CurrentVersion.Content = $"{updateManager.CurrentlyInstalledVersion()}";
                    var releaseEntry = await updateManager.UpdateApp();
                    NewVersion.Content = $"{releaseEntry?.Version.ToString() ?? "No update"}";
                }
            }
            catch(Exception ex)
            {
                try
                {
                    CurrentVersion.Content = "Not a squirrel install";
                }
                catch(Exception ex2)
                {

                }
            }
        }
    }
}
