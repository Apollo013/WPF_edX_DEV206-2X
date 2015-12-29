using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Behaviours
{
    public class RightClickWarnBehavior : DependencyObject, IBehavior
    {
        public string Message { get; set; }

        public DependencyObject AssociatedObject { get; private set; }

        public void Attach(DependencyObject associatedObject)
        {
            if(associatedObject != null)
            {
                this.AssociatedObject = associatedObject;
                (this.AssociatedObject as Page).RightTapped += PageRightTapped;
            }
        }

        public void Detach()
        {
            if (this.AssociatedObject != null && this.AssociatedObject is Page)
            {
                this.AssociatedObject = null;
                (this.AssociatedObject as Page).RightTapped -= PageRightTapped;
            }
        }

        private async void PageRightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            await new MessageDialog(this.Message).ShowAsync();
        }
    }
}
