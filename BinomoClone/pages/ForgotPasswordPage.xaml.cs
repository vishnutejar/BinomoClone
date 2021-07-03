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
    public partial class ForgotPasswordPage : ContentPage
    {
        //Page Type =0 we are from Via Phone Number
        //Page Type =1 we are from Via Email
        public ForgotPasswordPage() {
            InitializeComponent();
        }
        public ForgotPasswordPage(int pageType)
        {
            InitializeComponent();
            if (pageType == 0)
            {

                phonenumberentry.IsVisible = true;
                phonenumberlabel.IsVisible = true;
                Emailentry.IsVisible = false;
                Emaillabel.IsVisible = false;
            }
            else {
                phonenumberentry.IsVisible = false;
                phonenumberlabel.IsVisible = false;
                Emailentry.IsVisible = true;
                Emaillabel.IsVisible = true;
            }
        }
    }
}