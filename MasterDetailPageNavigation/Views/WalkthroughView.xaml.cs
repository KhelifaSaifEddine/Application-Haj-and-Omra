using MasterDetailPageNavigation.Views.Walkthrough;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walkthrough.Views.Walkthrough;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Rg.Plugins.Popup.Services;

namespace MasterDetailPageNavigation.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WalkthroughView : ContentPage
    {
        public static WalkthroughView instance { get; set; }
        public string name { get; set; }
        public string Asset { get; set; }
        int counter { get; set; }
        int current { get; set; }
        private View[] _views;
        public bool disable { get; set; }
        TapGestureRecognizer tapimge;
        public WalkthroughView()
        {
           
            current = 0;
            NavigationPage.SetHasNavigationBar(this, false);
            counter = 0;
            InitializeComponent();
            tapimge = new TapGestureRecognizer();
            tapimge.Tapped += tapImage_Tapped;
     
            img.GestureRecognizers.Add(tapimge);
          
            //-------------//
            var tapImage1 = new TapGestureRecognizer();
            tapImage1.Tapped += tapImage_Tapped1;
            img1.GestureRecognizers.Add(tapImage1);

            label.Opacity = 0;
            label1.Opacity = 0;
            LottieAnimation.Opacity = 0;
            BindingContext = this;
            Button.Opacity = 0;
            Button.IsEnabled = false;
            _views = new View[]
            {

               
                 new AcrobaticsView(),
                 new BikingHardView(),
                 new BikingCoolView(),
                new SoExcitedView(),
                new Direction_Safa_Marwa(),
                 new Safa_Marwa(),
                  new FinOmra(),


            };
            Carousel.ItemsSource = _views;

            (_views[0] as IAnimatedView).StartAnimation();



        }


        private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            if (!((IAnimatedView)_views[current] is BikingCoolView))
            {
                label.Opacity = 0;
                label1.Opacity = 0;
                LottieAnimation.Opacity = 0;
                Button.Opacity = 0;
                Button.IsEnabled = false;
            }
            current = e.NewValue;
            img.IsEnabled = true;
            if (!((IAnimatedView)_views[current] is BikingCoolView))
            {
                label.Opacity = 0;
                label1.Opacity = 0;
                LottieAnimation.Opacity = 0;
                Button.Opacity = 0;
                Button.IsEnabled = false;
            }

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
          
            Vibration.Vibrate();

            // Or use specified time
            var duration = TimeSpan.FromSeconds(0.2);
            Vibration.Vibrate(duration);
            LottieAnimation.Play();
            label.FadeTo(0, 2000);
            label1.FadeTo(0, 2000);
            counter++;
            label.Text = counter.ToString();

            label.FadeTo(1, 1000);
            label1.FadeTo(1, 1000);
            if (counter == 7)
            {
                ((Button)sender).IsEnabled = false;
                if (((IAnimatedView)_views[current] is BikingCoolView)) BikingCoolView.instance.Resume();

            }


        }

        void tapImage_Tapped(object sender, EventArgs e)
        {
            if (!((IAnimatedView)_views[current] is BikingCoolView))
            {
                label.Opacity = 0;
                label1.Opacity = 0;
                LottieAnimation.Opacity = 0;
                Button.Opacity = 0;
                Button.IsEnabled = false;
            }

            Carousel.Position++;

            if (!((IAnimatedView)_views[current] is BikingCoolView))
            {
                label.Opacity = 0;
                label1.Opacity = 0;
                LottieAnimation.Opacity = 0;
                Button.Opacity = 0;
                Button.IsEnabled = false;
            }
            Button.Opacity = 0; LottieAnimation.Opacity = 0; label.Opacity = 0;
            label1.Opacity = 0;
            if ((IAnimatedView)_views[current] is View1)
            {

                Navigation.PushAsync(new Haj_Walk()); return;
            }
            var currentView = _views[current + 1];



            ((IAnimatedView)currentView).StartAnimation();


            if (currentView is BikingCoolView || currentView is Safa_Marwa)
            {
                counter = 0;

                Button.IsEnabled = true;
                Button.FadeTo(1, 900);
                label.FadeTo(1, 900);
                label1.FadeTo(1, 900);
                LottieAnimation.FadeTo(1, 900);
            }
            else { Button.Opacity = 0; LottieAnimation.Opacity = 0; Button.IsEnabled = false; label.Opacity = 0; label1.Opacity = 0; }
            img.IsEnabled = false;
            Task.WaitAll();

            return;


        }

        void tapImage_Tapped1(object sender1, EventArgs e1)
        {
            if ((IAnimatedView)_views[current] is AcrobaticsView)
            {

                return;
            }
            // handle the tap  
            Button.Opacity = 0; LottieAnimation.Opacity = 0; label.Opacity = 0;
            label1.Opacity = 0;

            var currentView = _views[current - 1];



            ((IAnimatedView)currentView).StartAnimation();

            if (currentView is SoExcitedView) SoExcitedView.instace.StartAnimation();
            if (currentView is BikingCoolView || currentView is Safa_Marwa)
            {
                Button.IsEnabled = true;
                Button.FadeTo(1, 900);
                label.FadeTo(1, 900);
                label1.FadeTo(1, 900);
                LottieAnimation.FadeTo(1, 900);

            }
            else { Button.Opacity = 0; LottieAnimation.Opacity = 0; label.Opacity = 0; label1.Opacity = 0; Button.IsEnabled = false; }
            Carousel.Position--;

            return;

        }

        /*   private void Go_Clicked(object sender, System.EventArgs e)
  {
      Go.TranslationY = -100;

      Carousel.Position++;
      Go.TranslateTo(0, 0, 1250);
  }*/
    }
}