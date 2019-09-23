using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace MasterDetailPageNavigation.Views.Walkthrough
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 
	{
		public Page1 ()
		{
			InitializeComponent ();

        }
        private void Button_Clicked(object sender, System.EventArgs e)
        {
            PopupNavigation.Instance.PopAsync();

        }
    }
 
}