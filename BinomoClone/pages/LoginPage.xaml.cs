using BinomoClone.custompopup;
using Rg.Plugins.Popup.Services;
using System;

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

        private void ShowPopup(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new ForgotpasswordPopup());

        }

        private void ValidateUser(object sender, EventArgs e)
        {
            try
            {
                string phonumber, password;
                phonumber = phnumentry?.Text;
                password = passwordentry?.Text;
                if (password == null && phonumber == null) {
                    DisplayAlert("User Message", "Enter Your Phone Number and password", "ok");

                    return;
                }

                if (string.IsNullOrEmpty(phonumber))
                {
                    DisplayAlert("User Message", "Enter Your Phone Number", "ok");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    DisplayAlert("User Message", "Enter Your Password", "ok");

                }
                else
                {
                    bool IsPhoneNumer = phonumber.Length == 10;

                    if (!IsPhoneNumer)
                    {
                        DisplayAlert("User Message", "Phone Number have only 10 digits", "ok");

                    }
                    else
                    {

                        DisplayAlert("Congrasulations", "Thanks for login in to binomo app", "ok");

                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
           


        }
    }
}