using MasterDetailPageNavigation.Models;
using MasterDetailPageNavigation.ViewModels;
using MasterDetailPageNavigation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
        int counter = 0;
        MainPageViewModel Context, Checkboxes;
        Boolean[] AllCheck = new Boolean[6] { false, false, false, false, false, false };
        Boolean[] MiniAllCheck = new Boolean[3] { false, false, false };
        Boolean[] AllCheck2 = new Boolean[6] { false, false, false, false, false, false };
        Boolean enable;
        int Choice;
       
        public Main( int choix )
        {
            // MainCarousel.Position = 3;
            InitializeComponent();
            Choice = choix;
            //////CODE //////
            this.BindingContext = new MainPageViewModel();
            Checkboxes = new MainPageViewModel();
            //// init MainCarousel//
            enable = false;

            MainCarousel.ItemSelected += (sender, args) =>
            {
                if (!(args.SelectedItem is SliderViewItem item))
                    return;

                if (CarouselStepBar.Steps > 0)
                    CarouselStepBar.StepSelected = (int)item.Step;


            };

            CarouselStepBar.OnStepSelected += (sender, args) =>
            {
                if (!(args is int step))
                    return;
                var value = step;
                MainCarousel.Position = --value;
            };
            ////image one ////
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += tapImage_Tapped;
            img.GestureRecognizers.Add(tapImage);
            ///Image two///
            var tapImage1 = new TapGestureRecognizer();
            tapImage1.Tapped += tapImage_Tapped1;
            img1.GestureRecognizers.Add(tapImage1);

        }


        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            Context = this.BindingContext as MainPageViewModel;

            if (Context.Data.Count > 0)
            {
                CarouselStepBar.StepSelected = 1;
            }
        }

        void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            int k;
            SliderViewItem go = (SliderViewItem)MainCarousel.Item;
            if (enable)
            {
                k = 0;
                while (k < 3)
                {
                    if (AllCheck[k] == false) break;
                    k++;
                }
                if (k == 3) { MainCarousel.Position = 0; MainCarousel.Position = 0; return; }

                foreach (Boolean i in AllCheck)
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Check ");
                    Console.WriteLine(i);
                    Console.WriteLine("---------fffffffffffffffffff-----------------------------");
                }
                if (MainCarousel.Position == 2 && go.Check == true)
                {
                    AllCheck[2] = true;
                    MainCarousel.Position = 0;
                    counter++;
                    return;

                }
                else
                {
                    if (go.Check == true && MainCarousel.Position < 2)
                    {
                        AllCheck[go.Step - 1] = true;
                        MainCarousel.Position = go.Step;
                        Verf();
                    }
                }
                if (go.Check == false)
                {
                    AllCheck[go.Step - 1] = false;
                    counter--;
                }



                if (AllCheck.Any(x => x == false))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (AllCheck[j] == false)
                        {
                            MainCarousel.Position = j;
                            break;
                        }

                    }
                }
            }
            else
            {
                //---------------------------------------------------------------///

                k = 3;
                while (k < 6)
                {
                    if (AllCheck[k] == false) break;
                    k++;
                }
                if (k == 6) { MainCarousel.Position = 3; return; }
                //----------------------------------------------------------------///
                if (k == 6) { MainCarousel.Position = 3; return; }
                if (MainCarousel.Position == 5 && go.Check == true)
                {
                    AllCheck[5] = true;
                    MainCarousel.Position = 3;
                    counter++;
                    return;

                }
                else
                {
                    if (go.Check == true && MainCarousel.Position < 5)
                    {
                        AllCheck[go.Step - 1] = true;
                        MainCarousel.Position = go.Step;
                        Verf();
                    }
                }
                if (go.Check == false)
                {
                    AllCheck[go.Step - 1] = false;
                    counter--;
                }



                if (AllCheck.Any(x => x == false))
                {
                    for (int j = 3; j < 6; j++)
                    {
                        if (AllCheck[j] == false)
                        {
                            MainCarousel.Position = j;
                            break;
                        }

                    }
                }
            }
        }
        void Verf()
        {
            int b;
            if (enable)
            {

                MainCarousel.ItemSelected += (sender, args) =>
                {
                    if (!(args.SelectedItem is SliderViewItem item))
                        return;

                    b = 0;
                    while (b < 3)
                    {
                        if (AllCheck[b] == false) break;
                        b++;
                    }
                    if (b == 3) { MainCarousel.Position = 0; return; }


                    if (item.Check == true)
                    {
                        if (MainCarousel.Position < 2)
                        {
                            MainCarousel.Position = item.Step;
                            if (CarouselStepBar.Steps > 0)
                                CarouselStepBar.StepSelected = (int)item.Step;
                            counter++;
                        }


                    }
                };
                // --------------------------//
            }
            else
            {
                MainCarousel.ItemSelected += (sender, args) =>
                {
                    if (!(args.SelectedItem is SliderViewItem item))
                        return;
                    b = 3;
                    while (b < 6)
                    {
                        if (AllCheck[b] == false) break;
                        b++;
                    }
                    if (b == 6) { MainCarousel.Position = 3; return; }



                    if (item.Check == true)
                    {
                        if (MainCarousel.Position < 5)
                        {
                            MainCarousel.Position = item.Step;
                            if (CarouselStepBar.Steps > 3)
                                CarouselStepBar.StepSelected = (int)item.Step;
                            counter++;
                        }


                    }

                };
            }
            return;
        }
        void tapImage_Tapped(object sender, EventArgs e)
        {
            enable = true;
            MainCarousel.Position = 0;
            return;
        }

        private void Nextpage_Clicked(object sender, EventArgs e)
        {
            if (Choice == 0)
            {
                Navigation.PushAsync(new WalkthroughView());
            }
            else
            {
                Navigation.PushAsync(new Haj_Walk_Two());
            }
        }

        void tapImage_Tapped1(object sender, EventArgs e)
        {
            // handle the tap    

            enable = false;
            MainCarousel.Position = 3;
            return;
        }
    }
}
