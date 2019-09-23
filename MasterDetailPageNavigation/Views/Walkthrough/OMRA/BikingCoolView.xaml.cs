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
    public partial class BikingCoolView : IAnimatedView
    {
        public static BikingCoolView instance { get; set; }
        bool enable { get; set; }

        public BikingCoolView()
        { 
            InitializeComponent();
            instance = this;
            enable = true;
            LottieAnimation.Loop = false;
        }

        public void StartAnimation()
        {LottieAnimation.Loop = false;
         enable = false; LottieAnimation.PlayFrameSegment(0, 82);}
        public void StopAnimation()
        {

        }

        private void LottieAnimation_OnFinish(object sender, EventArgs e)
        {
            Task.WaitAll();
            LottieAnimation.Pause();
            PopupNavigation.Instance.PushAsync(new Page1());
            Task.WaitAll();
            if (enable == false)
            {
                LottieAnimation.PlayFrameSegment(82, 277);
                LottieAnimation.Loop = true;
                enable = true;
            }
        }

        private void LottieAnimation_OnPlay(object sender, EventArgs e)
        {
           
        }
        public void Resume()
        {
            LottieAnimation.Loop = false;
            LottieAnimation.PlayFrameSegment(277, 435);
            Task.WaitAll();
            PopupNavigation.Instance.PushAsync(new Page2());
        }
    }
}