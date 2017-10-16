using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPlayground.Core
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewCell : ViewCell
	{
        public ListViewCell()
        {
            InitializeComponent();
        }
    }
}