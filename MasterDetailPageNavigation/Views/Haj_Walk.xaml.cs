﻿using MasterDetailPageNavigation.Views.Walkthrough;
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
	public partial class Haj_Walk : ContentPage
	{
      
        public string name { get; set; }
        public string Asset { get; set; }
        int counter { get; set; }
        int current { get; set; }
        private View[] _views;
        public bool disable { get; set; }
        TapGestureRecognizer tapimge;
        public Haj_Walk ()
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

                new View4(),
                new View5(),
                new View6(),
                new View7(),
                new ViewA(),
                new ViewE(),
                new ViewZ(),


            };

            Carousel.ItemsSource = _views;

            (_views[0] as IAnimatedView).StartAnimation();



        }


        private void OnCarouselPositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {

            current = e.NewValue;
            img.IsEnabled = true;

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



        }

        void tapImage_Tapped(object sender, EventArgs e)
        {

            Carousel.Position++;
            Button.Opacity = 0; LottieAnimation.Opacity = 0; label.Opacity = 0;
            label1.Opacity = 0;
            if ((IAnimatedView)_views[current] is View7)
            {

                Navigation.PushAsync(new Haj_Walk_Fourth()); return;
            }
            var currentView = _views[current + 1];



            ((IAnimatedView)currentView).StartAnimation();


            if (currentView is BikingCoolView || currentView is Safa_Marwa)
            {


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
            // handle the tap  
            Button.Opacity = 0; LottieAnimation.Opacity = 0; label.Opacity = 0;
            label1.Opacity = 0;
            if ((IAnimatedView)_views[current] is View4)
            {

                Navigation.PushAsync(new Haj_Walk_Three()); return;
            }
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