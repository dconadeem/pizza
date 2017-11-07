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
    public partial class Promotions : ContentPage
    {
        public Promotions()
        {
            InitializeComponent();
        }
        private void P1_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion1";
            Navigation.PushAsync(new orderPage(orderno));
        }
        private void P2_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion2";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P3_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion3";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P4_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion4";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P5_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion5";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P6_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion6";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P7_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion7";
            Navigation.PushAsync(new orderPage(orderno));

        }
        private void P8_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion8";
            Navigation.PushAsync(new orderPage(orderno));

        }

        private void P9_OnTapped(object sender, EventArgs e)
        {
            string orderno = "Promotion9";
            Navigation.PushAsync(new orderPage(orderno));

        }
    }
}