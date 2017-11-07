using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pizza
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void M1_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu1";
            Navigation.PushAsync(new orderPage(orderno));
            
        }
        private void M2_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu2";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M3_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu3";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M4_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu4";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M5_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu5";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M6_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu6";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M7_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu7";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void M8_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Menu8";
            Navigation.PushAsync(new orderPage(orderno));

        }


    }
}