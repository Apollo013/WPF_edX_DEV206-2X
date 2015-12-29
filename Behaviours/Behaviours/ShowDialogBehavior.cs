using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Behaviours
{
    public class ShowDialogBehavior : DependencyObject, IBehavior
    {
        public string Message { get; set; }

        public DependencyObject AssociatedObject { get; private set; }

        public void Attach(DependencyObject associatedObject)
        {
            if (associatedObject != null)
            {
                this.AssociatedObject = associatedObject;
                (this.AssociatedObject as Button).Click += ButtonClick;
            }
        }

        public void Detach()
        {
            if (this.AssociatedObject != null && this.AssociatedObject is Page)
            {
                this.AssociatedObject = null;
                (this.AssociatedObject as Button).Click -= ButtonClick;
            }
        }

        private async void ButtonClick(object sender, RoutedEventArgs e)
        {
            await new MessageDialog(this.Message).ShowAsync();
        }
    }
}
