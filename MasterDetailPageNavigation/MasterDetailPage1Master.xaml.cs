using Newtonsoft.Json;
using Plugin.Connectivity;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Master : ContentPage
    {
        public static MasterDetailPage1Master Instance = null;
        public MasterDetailPage1Master()
        {
            InitializeComponent();
            Instance = this;
            if (Application.Current.Properties.ContainsKey("Latbut1") && Application.Current.Properties.ContainsKey("Longbut1"))
            {
                saveloca1.Text = Application.Current.Properties["Tente1"].ToString();
                saveloca1.IsVisible = true;
            }
            else
            {
                saveloca1.IsVisible = false;
            }
            if (Application.Current.Properties.ContainsKey("Latbut2") && Application.Current.Properties.ContainsKey("Longbut2"))
            {
                saveloca2.Text = Application.Current.Properties["Tente2"].ToString();
                saveloca2.IsVisible = true;
            }
            else
            {
                saveloca2.IsVisible = false;
            }
            if (Application.Current.Properties.ContainsKey("Latbut3") && Application.Current.Properties.ContainsKey("Longbut3"))
            {
                saveloca3.Text = Application.Current.Properties["Tente3"].ToString();
                saveloca3.IsVisible = true;
            }
            else
            {
                saveloca3.IsVisible = false;
            }
            if (Application.Current.Properties.ContainsKey("Latbut4") && Application.Current.Properties.ContainsKey("Longbut4"))
            {
                saveloca4.Text = Application.Current.Properties["Tente4"].ToString();
                saveloca4.IsVisible = true;
            }
            else
            {
                saveloca4.IsVisible = false;
            }
            if (Application.Current.Properties.ContainsKey("Latbut5") && Application.Current.Properties.ContainsKey("Longbut5"))
            {
                saveloca5.Text = Application.Current.Properties["Tente5"].ToString();
                saveloca5.IsVisible = true;
            }
            else
            {
                saveloca5.IsVisible = false;
            }
        }

        private async void Saveloca1_Clicked(object sender, EventArgs e)
        {

            string action = await DisplayActionSheet("اختيار", "إلغاء", null, "حذف", "الذهاب إلى خيمة");
            if (action.Equals("الذهاب إلى خيمة") == true)
            {
                Application.Current.Properties["Lat"] = Application.Current.Properties["Latbut1"];
                Application.Current.Properties["Long"] = Application.Current.Properties["Longbut1"];
                MasterDetailPage1.Instance.IsPresented = false;
                MasterDetailPage1Detail.Instance.cccv();
            }
            else // deleat
            {
                if (action.Equals("حذف") == true)
                {
                    Application.Current.Properties.Remove("Latbut1");
                    Application.Current.Properties.Remove("Longbut1");
                    await DisplayAlert("نجاح", "تم حذف خيمتك!", "OK");
                    saveloca1.IsVisible = false;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Remove(MasterDetailPage1Detail.Pin1);
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                }
            }
        }

        private async void Saveloca2_Clicked(object sender, EventArgs e)
        {

            string action = await DisplayActionSheet("اختيار", "إلغاء", null, "حذف", "الذهاب إلى خيمة");
            if (action.Equals("الذهاب إلى خيمة") == true)
            {
                Application.Current.Properties["Lat"] = Application.Current.Properties["Latbut2"];
                Application.Current.Properties["Long"] = Application.Current.Properties["Longbut2"];
                MasterDetailPage1.Instance.IsPresented = false;
                MasterDetailPage1Detail.Instance.cccv();
            }
            else // deleat
            {
                if (action.Equals("حذف") == true)
                {
                    Application.Current.Properties.Remove("Latbut2");
                    Application.Current.Properties.Remove("Longbut2");
                    await DisplayAlert("نجاح", "تم حذف خيمتك!", "OK");
                    saveloca2.IsVisible = false;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Remove(MasterDetailPage1Detail.Pin2);
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                }

            }
        }

        private async void Saveloca3_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("اختيار", "إلغاء", null, "حذف", "الذهاب إلى خيمة");
            if (action.Equals("الذهاب إلى خيمة") == true)
            {
                Application.Current.Properties["Lat"] = Application.Current.Properties["Latbut3"];
                Application.Current.Properties["Long"] = Application.Current.Properties["Longbut3"];
                MasterDetailPage1.Instance.IsPresented = false;
                MasterDetailPage1Detail.Instance.cccv();
            }
            else // deleat
            {
                if (action.Equals("حذف") == true)
                {
                    Application.Current.Properties.Remove("Latbut3");
                    Application.Current.Properties.Remove("Longbut3");
                    await DisplayAlert("نجاح", "تم حذف خيمتك!", "OK");
                    saveloca3.IsVisible = false;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Remove(MasterDetailPage1Detail.Pin3);
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                }
            }
        }

        private async void Saveloca4_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("اختيار", "إلغاء", null, "حذف", "الذهاب إلى خيمة");
            if (action.Equals("الذهاب إلى خيمة") == true)
            {
                Application.Current.Properties["Lat"] = Application.Current.Properties["Latbut4"];
                Application.Current.Properties["Long"] = Application.Current.Properties["Longbut4"];
                MasterDetailPage1.Instance.IsPresented = false;
                MasterDetailPage1Detail.Instance.cccv();
            }
            else // deleat
            {
                if (action.Equals("حذف") == true)
                {
                    Application.Current.Properties.Remove("Latbut4");
                    Application.Current.Properties.Remove("Longbut4");
                    await DisplayAlert("نجاح", "تم حذف خيمتك!", "OK");
                    saveloca4.IsVisible = false;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Remove(MasterDetailPage1Detail.Pin4);
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                }
            }
        }

        private async void Saveloca5_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("اختيار", "إلغاء", null, "حذف", "الذهاب إلى خيمة");
            if (action.Equals("الذهاب إلى خيمة") == true)
            {
                Application.Current.Properties["Lat"] = Application.Current.Properties["Latbut5"];
                Application.Current.Properties["Long"] = Application.Current.Properties["Longbut5"];
                MasterDetailPage1.Instance.IsPresented = false;
                MasterDetailPage1Detail.Instance.cccv();
            }
            else // deleat
            {
                if (action.Equals("حذف") == true)
                {
                    Application.Current.Properties.Remove("Latbut5");
                    Application.Current.Properties.Remove("Longbut5");
                    await DisplayAlert("نجاح", "تم حذف خيمتك!", "OK");
                    saveloca5.IsVisible = false;
                    MasterDetailPage1Detail.Instance.myMap.Pins.Remove(MasterDetailPage1Detail.Pin5);
                    MasterDetailPage1Detail.Instance.Content = MasterDetailPage1Detail.Instance.myMap;
                }

            }
        }

        private async void Addtente_Clicked(object sender, EventArgs e)
        {
            int i = 1;
            for (; i < 6; i++)
            {
                if (!Application.Current.Properties.ContainsKey("Latbut" + i) && !Application.Current.Properties.ContainsKey("Longbut" + i))
                {
                    var x = MasterDetailPage1Detail.position;
                    if (x == null)
                    {
                        await DisplayAlert("انتظر ..", "انتظر حتى يمكننا الحصول على موقعك الحالي!", "OK");
                    }
                    else
                    {
                        var v = new Popupview(i);
                        await PopupNavigation.Instance.PushAsync(new Popupview(i));
                    }
                    break;
                }
            }
            if (i == 6)
            {
                await DisplayAlert("Ok", "لقد وصلت إلى الحد الأقصى لعدد الخيمة", "OK");
            }

        }

        private void V_Disappearing5(object sender, EventArgs e)
        {
            saveloca5.Text = Application.Current.Properties["TenteName"].ToString();
            saveloca5.IsVisible = true;
        }

        private void V_Disappearing4(object sender, EventArgs e)
        {
            saveloca4.Text = Application.Current.Properties["TenteName"].ToString();
            saveloca4.IsVisible = true;
        }

        private void V_Disappearing3(object sender, EventArgs e)
        {
            saveloca3.Text = Application.Current.Properties["TenteName"].ToString();
            saveloca3.IsVisible = true;
        }

        private void V_Disappearing2(object sender, EventArgs e)
        {
            saveloca2.Text = Application.Current.Properties["TenteName"].ToString();
            saveloca2.IsVisible = true;
        }
    }
}
