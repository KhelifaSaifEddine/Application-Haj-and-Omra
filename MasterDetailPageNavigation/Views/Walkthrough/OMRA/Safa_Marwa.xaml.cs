using Rg.Plugins.Popup.Services;
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
	public partial class Safa_Marwa : IAnimatedView
    {
		public Safa_Marwa ()
		{
			InitializeComponent ();
            LottieAnimation.Loop = false;
        }

        public void StartAnimation()
        {
            PopupNavigation.Instance.PushAsync(new Page3());
            LottieAnimation.Loop = false;
         LottieAnimation.PlayFrameSegment(0, 82);

        }

     
        public void StopAnimation()
        {
            
        }

        private void LottieAnimation_OnFinish(object sender, EventArgs e)
        {
            LottieAnimation.PlayFrameSegment(82, 300);
            LottieAnimation.Loop = true;}

    }
}