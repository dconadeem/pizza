using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pizza
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class orderPage : ContentPage
    {
        public orderPage(string offer)
        {
            InitializeComponent();
            lblorder.Text = offer;
        }

        private  void BtnOrder_OnClicked(object sender, EventArgs e)
        {
            pizzApp pizzapp=new pizzApp
            { 
              MenuName = EntOrder.Text,
              FirstName = EntFirstName.Text,
              LastName = EntLastName.Text,
              Email = EntEmail.Text,
              Phoneno = EntPhone.Text,
              Address = EntAddress.Text,
          
            
            };
            DisplayAlert("Order", "Order has been Placed", "Ok");
            HttpClient httpClient=new HttpClient();
            var json =JsonConvert.SerializeObject(pizzapp);
            HttpContent httpContent=new StringContent(json);
            httpContent.Headers.ContentType=new MediaTypeHeaderValue("application/json");
            httpClient.PostAsync("http://piza.azurewebsites.net/api/PizzAppApi", httpContent);
            //http://piza.azurewebsites.net/PizzaApp
        }


    }
}