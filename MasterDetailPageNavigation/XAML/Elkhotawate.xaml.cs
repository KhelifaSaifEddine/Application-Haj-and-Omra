using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
	
	public partial class Elkhotawate : ContentPage
	{
       // bool _collapsed  ;
		public Elkhotawate ()
		{

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            ////image one ////
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += tapImage_Tapped;
            img.GestureRecognizers.Add(tapImage);
            ///Image two///
            var tapImage1 = new TapGestureRecognizer();
            tapImage1.Tapped += tapImage_Tapped1;
            img1.GestureRecognizers.Add(tapImage1);

        }
        void tapImage_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Main(0));
        }
        void tapImage_Tapped1(object sender, EventArgs e)
        {
            // handle the tap    
            Navigation.PushAsync(new Main(1));

        }
    }
}