using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walkthrough.Views.Walkthrough;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation.Views.Walkthrough
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FinOmra : IAnimatedView
	{
		public FinOmra ()
		{
			InitializeComponent ();
		}

        public void StartAnimation()
        {
            LottieAnimation.Play();
        }

        public void StopAnimation()
        {
            throw new NotImplementedException();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

    
    }
}