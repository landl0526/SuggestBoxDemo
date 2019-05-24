using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SuggestBoxDemo
{
    public class CustomSuggestBox : View
    {
        public System.Collections.IList ItemsSource
        {
            get { return GetValue(ItemsSourceProperty) as System.Collections.IList; }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create(nameof(ItemsSource), typeof(System.Collections.IList), typeof(CustomSuggestBox), null, BindingMode.OneWay, null, null);
    }
}
