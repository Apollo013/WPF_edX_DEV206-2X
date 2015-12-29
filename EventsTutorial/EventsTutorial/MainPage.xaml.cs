using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EventsTutorial
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Circle_Click(object sender, MessageEventArgs e)
        {
            var dialog = new MessageDialog(e.Message, "Circle");
            await dialog.ShowAsync();
        }

        private async void Tapped_Handle(object sender, TappedRoutedEventArgs e)
        {
            if(sender is StackPanel)
            {
                e.Handled = true;
            }
            var dialog = new MessageDialog($"Hello {e.Handled} : {e.OriginalSource} : {e.GetType().ToString()}");
            await dialog.ShowAsync();
        }
    }
}
