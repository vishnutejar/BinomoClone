using BinomoClone.custompopup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinomoClone.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        string phonumber, password;


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
                phonumber = phnumentry?.Text;
                password = passwordentry?.Text;
             

                if (string.IsNullOrWhiteSpace(phonumber))
                {
                    DisplayAlert("User Message", "Enter Your Phone Number", "ok");
                }
                else if (string.IsNullOrWhiteSpace(password))
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
                        /*validate your number using regex*/
                        // Navigation.PushAsync(new HomePage());
                        App.Current.MainPage = new NavigationPage(new HomePage());

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