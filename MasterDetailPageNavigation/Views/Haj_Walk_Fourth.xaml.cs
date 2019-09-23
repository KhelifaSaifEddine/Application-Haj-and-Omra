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
	public partial class Haj_Walk_Fourth : ContentPage
	{
        public string name { get; set; }
        public string Asset { get; set; }
        int counter { get; set; }
        int current { get; set; }
        private View[] _views;
        public bool disable { get; set; }
        TapGestureRecognizer tapimge;
        public Haj_Walk_Fourth ()
		{
			InitializeComponent ();
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


            BindingContext = this;

            _views = new View[]
            {
                 new View15(),
                 new View16(),
                 new Finhaj(),
                

            };

            Carousel.ItemsSource = _views;

            (_views[0] as IAnimatedView).StartAnimation();



        }


        private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {

            current = e.NewValue;
            img.IsEnabled = true;
            img1.IsEnabled = true;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Vibration.Vibrate();

            // Or use specified time
            var duration = TimeSpan.FromSeconds(0.2);
            Vibration.Vibrate(duration);

            counter++;






        }

        void tapImage_Tapped(object sender, EventArgs e)
        {

            Carousel.Position++;
            if ((IAnimatedView)_views[current] is View16)
            {

                 return;
            }
            var currentView = _views[current + 1];



            ((IAnimatedView)currentView).StartAnimation();



            img.IsEnabled = false;
            Task.WaitAll();

            return;


        }

        void tapImage_Tapped1(object sender1, EventArgs e1)
        {
            // handle the tap  

            if ((IAnimatedView)_views[current] is View15)
            {

                return;
            }
            var currentView = _views[current - 1];



            ((IAnimatedView)currentView).StartAnimation();

            img1.IsEnabled = false;
            Task.WaitAll();
            Carousel.Position--;

            return;

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Main(1));
        }

        /*   private void Go_Clicked(object sender, System.EventArgs e)
  {
      Go.TranslationY = -100;

      Carousel.Position++;
      Go.TranslateTo(0, 0, 1250);
  }*/
    }
}