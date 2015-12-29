using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace DependencyProperties
{
    public class LoadingProperties : DependencyObject
    {


        public static readonly DependencyProperty IsLoadingProperty = DependencyProperty.RegisterAttached("IsLoading", typeof(bool), typeof(LoadingProperties), new PropertyMetadata(false));

        public static void SetIsLoading(UIElement element,Boolean value)
        {
            element.SetValue(IsLoadingProperty, value);
        }

        public static bool GetIsLoading(UIElement element)
        {
            return (bool)element.GetValue(IsLoadingProperty);
        }

    }
}
