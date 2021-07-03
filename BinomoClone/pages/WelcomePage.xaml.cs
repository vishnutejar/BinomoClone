using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinomoClone.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        string data = "dlkdhkhdgsdhgksdgkd wrweorweroweur hiehreifhhiwef oiwehfwerhwerfwhif";
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void NaviagteLoginPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void NavigateToSignUpPage(object sender, EventArgs e)
        {
            DisplayAlert("title", "message", "ok");
        }
    }
}