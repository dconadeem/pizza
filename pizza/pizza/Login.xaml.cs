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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ImgRound.RotateTo(360, 2500, Easing.Linear);
            await ImgRound.TranslateTo(0, 200, 2500, Easing.Linear);
            await ImgRound.TranslateTo(0, -80, 2500, Easing.Linear);
            SLlogin.IsVisible = true;


        }

        private void BtnMenu_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());
 
        }

        private void BtnLogin_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());

        }

        private void BtnSignup_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());
           
        }
    }
}