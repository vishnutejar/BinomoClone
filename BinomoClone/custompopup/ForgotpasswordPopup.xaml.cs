using BinomoClone.pages;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinomoClone.custompopup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForgotpasswordPopup : PopupPage
    {
        public ForgotpasswordPopup()
        {
            InitializeComponent();
        }

        private void ClosePopup(object sender, EventArgs e)
        {
            PopupNavigation.PopAsync();
        }

        private void NavigateToForgotPasswordViaPhone(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage(0));
            PopupNavigation.PopAsync();

        }

        private void NavigateToForgotPasswordViaEMail(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPasswordPage(1));
            PopupNavigation.PopAsync();


        }
    }
}