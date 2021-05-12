using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnBMDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BindingModeDemo());
            };
            btnLVDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            btnPKDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PickerDemo());
            };
        }
    }
}
