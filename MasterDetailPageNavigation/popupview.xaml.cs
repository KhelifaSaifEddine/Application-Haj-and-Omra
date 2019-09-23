using Plugin.Geolocator.Abstractions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Popupview : PopupPage
    {
        int n;
        public Popupview(int n)
        {
            this.n = n;
            InitializeComponent();
        }

        private void TenteName_Clicked(object sender, EventArgs e)
        {
            var x = MasterDetailPage1Detail.position;
            switch (n)
            {
                case 1:
                    Application.Current.Properties["Latbut1"] = x.Latitude.ToString();
                    Application.Current.Properties["Longbut1"] = x.Longitude.ToString();
                    MasterDetailPage1Master.Instance.saveloca1.Text = cccv.Text;
                    Application.Current.Properties["Tente1"] = cccv.Text;
                    MasterDetailPage1Master.Instance.saveloca1.IsVisible = true;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Clear();
                    MasterDetailPage1Detail.Instance.Content = null;
                    MasterDetailPage1Detail.Instance.AffichePin();
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                    break;
                case 2:
                    Application.Current.Properties["Latbut2"] = x.Latitude.ToString();
                    Application.Current.Properties["Longbut2"] = x.Longitude.ToString();
                    MasterDetailPage1Master.Instance.saveloca2.Text = cccv.Text;
                    Application.Current.Properties["Tente2"] = cccv.Text;
                    MasterDetailPage1Master.Instance.saveloca2.IsVisible = true;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Clear();
                    MasterDetailPage1Detail.Instance.Content = null;
                    MasterDetailPage1Detail.Instance.AffichePin();
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                    break;
                case 3:
                    Application.Current.Properties["Latbut3"] = x.Latitude.ToString();
                    Application.Current.Properties["Longbut3"] = x.Longitude.ToString();
                    MasterDetailPage1Master.Instance.saveloca3.Text = cccv.Text;
                    Application.Current.Properties["Tente3"] = cccv.Text;
                    MasterDetailPage1Master.Instance.saveloca3.IsVisible = true;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Clear();
                    MasterDetailPage1Detail.Instance.Content = null;
                    MasterDetailPage1Detail.Instance.AffichePin();
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                    break;
                case 4:
                    Application.Current.Properties["Latbut4"] = x.Latitude.ToString();
                    Application.Current.Properties["Longbut4"] = x.Longitude.ToString();
                    MasterDetailPage1Master.Instance.saveloca4.Text = cccv.Text;
                    Application.Current.Properties["Tente4"] = cccv.Text;
                    MasterDetailPage1Master.Instance.saveloca4.IsVisible = true;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Clear();
                    MasterDetailPage1Detail.Instance.Content = null;
                    MasterDetailPage1Detail.Instance.AffichePin();
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                    break;
                case 5:
                    Application.Current.Properties["Latbut5"] = x.Latitude.ToString();
                    Application.Current.Properties["Longbut5"] = x.Longitude.ToString();
                    MasterDetailPage1Master.Instance.saveloca5.Text = cccv.Text;
                    Application.Current.Properties["Tente5"] = cccv.Text;
                    MasterDetailPage1Master.Instance.saveloca5.IsVisible = true;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Clear();
                    MasterDetailPage1Detail.Instance.Content = null;
                    MasterDetailPage1Detail.Instance.AffichePin();
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                    break;
            }
            PopupNavigation.Instance.PopAsync(true);
        }
    }
}