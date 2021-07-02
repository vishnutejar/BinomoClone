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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void NavigateToEmailLogin(object sender, EventArgs e)
        {
            usernameoremail.IsVisible = true;
            emailentry.IsVisible = true;
            usephonenumberinsteadlabel.IsVisible = true;
            phonenumberentrys.IsVisible = false;
            phonenumberlabel.IsVisible = false;
            useemailorusernamelabel.IsVisible = false;
            
        }

        private void NavigateToPhoneNumber(object sender, EventArgs e)
        {
            usernameoremail.IsVisible = false;
            emailentry.IsVisible = false;
            usephonenumberinsteadlabel.IsVisible = false;
            phonenumberentrys.IsVisible = true;
            phonenumberlabel.IsVisible = true;
            useemailorusernamelabel.IsVisible = true;
        }
    }
}