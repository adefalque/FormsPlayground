using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPlayground.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListViewButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ListViewPage());
        }

        private void FastListViewButton_OnClickedListViewButton_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new FastListViewPage());
        }
    }
}