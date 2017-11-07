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
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
            this.Detail = new Promotions();
            IsPresented = false;

        }

        private void BtnPromotions_OnClicked(object sender, EventArgs e)
        {
            this.Detail=new Promotions();
            IsPresented = false;
        }

        private void BtnMenu_OnClicked(object sender, EventArgs e)
        {
            this.Detail=new Menu();
            IsPresented = false;
        }

        private void BtnCombo_OnClicked(object sender, EventArgs e)
        {
            this.Detail=new Combo();
            IsPresented = false;
        }

        private void Login_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}