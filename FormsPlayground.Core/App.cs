using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsPlayground.Core
{
    public class App : Application
    {
        public App()
        {
            this.MainPage = new NavigationPage(new MainPage());
        }
    }
}
