using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace BinomoClone.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        ObservableCollection<string> lstMenus { get; set; }
        public HomePage()
        {
            InitializeComponent();
            lstMenus = new ObservableCollection<string>
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
            };

            masterMenulst.ItemsSource = lstMenus;

        }

        private void ValidateUser(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}