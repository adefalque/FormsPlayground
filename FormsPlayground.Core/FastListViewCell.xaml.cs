using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsPlayground.Core.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPlayground.Core
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FastListViewCell : FastCell
	{
		//public FastListViewCell ()
		//{
		//	InitializeComponent ();
		//}

        protected override void InitializeCell()
        {
            InitializeComponent();
        }

        protected override void SetupCell(bool isRecycled)
        {
            //var entity = this.BindingContext as Entity;

            //if (entity != null)
            //{
            //    ImageEntityView.Source = entity.ImageName;
            //    InitialsView.Text = entity.Initials;
            //    InitialsView.IsVisible = entity.HasInitials;
            //    ListPrimaryView.Text = entity.ListPrimary;
            //    ListSecondaryView.Text = entity.ListSecondary;

            //}
        }
    }
}