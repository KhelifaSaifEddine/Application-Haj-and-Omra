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
    public partial class SoExcitedView : IAnimatedView
    {
        public static SoExcitedView instace { get; set; }  
        public SoExcitedView()
        {
            InitializeComponent();
            instace = this;

        }

        public void StartAnimation()
        {

            LottieAnimation.Play();
        }
        public void StopAnimation()
        {

        }
    }
}