using SuggestBoxDemo;
using SuggestBoxDemo.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomSuggestBox), typeof(AutoSuggestBoxRenderer))]
namespace SuggestBoxDemo.UWP
{
    public class AutoSuggestBoxRenderer : ViewRenderer<CustomSuggestBox, AutoSuggestBox>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomSuggestBox> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new AutoSuggestBox());
                UpdateItemsSource();
            }
        }

        private void UpdateItemsSource()
        {
            if (Element.ItemsSource.Count > 0)
            {

                Control.ItemsSource = Element.ItemsSource;
            }
        }
    }
}
