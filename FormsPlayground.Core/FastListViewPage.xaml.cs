using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPlayground.Core
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FastListViewPage : ContentPage
    {
        public ObservableCollection<Entity> Items { get; set; }

        public FastListViewPage()
        {
            InitializeComponent();

            var service = new EntityService();
            Items = service.GetSampleEntities();

            BindingContext = this;
        }
        
    }
}