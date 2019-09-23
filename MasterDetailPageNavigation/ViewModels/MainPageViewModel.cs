using MasterDetailPageNavigation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MasterDetailPageNavigation.ViewModels
{
    public class MainPageViewModel 
    {

        static public MainPageViewModel instance { get; set; }
        public String[] Men = new String[3] { "MenOne.png", "MenTwo.png", "MenThree.png" }; public String[] Womeen = new String[3] { "WomenOne.png", "WomenTwo.png", "WomenThree.png" };
        public IList<SliderViewItem> Data { get; set; } = new List<SliderViewItem>()
        {
            new SliderViewItem()
            {
           //     Title = "Users",
                Description = "تقليم الأظافر و قص الشارب وازالة شعر الابطين والعانة",
                Icon = "MenOne.png",
                Step = 1,
                Check = false,
           //     BackgroundColor = Xamarin.Forms.Color.FromHex("#00BCD4")
            },
            new SliderViewItem()
            {
           //     Title = "Favorites",
                Description = "خلع الملابس المخيطة و لبس لباس الاحرام ",
              Icon = "MenTwo.png",
                Step = 2,
                  Check = false,
           //     BackgroundColor = Xamarin.Forms.Color.FromHex("#E91E63")
            },
            new SliderViewItem()
            {
            //    Title = "Messages",
                Description = " بعد الاغتسال التطيب في البدن فقط بما تيسر لك من طيب. -ليس من الواجب الاغتسال",
              Icon = "MenThree.png",
                Step = 3,
                  Check = false,
            //    BackgroundColor = Xamarin.Forms.Color.FromHex("#00BCD4")
            },
            new SliderViewItem()
            {
             //   Title = "Events",
                Description = "تقليم الأظافر  وازالة شعر الابطين والعانة",
              Icon = "WomenOne",
                Step = 4,
                  Check = false,
            //    BackgroundColor = Xamarin.Forms.Color.FromHex("#E91E63")
            },
            new SliderViewItem()
            {
                //Title = "Explore",
                Description = "تلبس المرأة مايستر بدنها بدون برقع أو قفاز أو نقاب",
                Icon = "WomenTwo",
                Step = 5,
                  Check = false,
                //  BackgroundColor = Xamarin.Forms.Color.FromHex("#00BCD4")
            },
            new SliderViewItem()
            {
                //Title = "Explore",
                Description = "-بعد اغتسال التطيب في البدن فقط  بما لايظهر ريحها. -ليس من الواجب الاغتسال",
                Icon = "WomenThree",
                Step = 6,
                  Check = false,
              //  BackgroundColor = Xamarin.Forms.Color.FromHex("#00BCD4")
            }
        };

        

        public MainPageViewModel()
        {
            
            instance = this;
        }

    }
}
