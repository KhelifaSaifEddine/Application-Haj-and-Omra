using Newtonsoft.Json;
using Plugin.Connectivity;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        public static MasterDetailPage1Detail Instance = null;
        public static Plugin.Geolocator.Abstractions.Position position;
        static public CustomMap customMap = new CustomMap();
        public static int SelectMap;
        public static Pin pinarrive, pindep;
        public static HttpClient _client = new HttpClient();
        public static Pin Pin1, Pin2, Pin3, Pin4, Pin5 = null;
        public MasterDetailPage1Detail()
        {
            InitializeComponent();
            Instance = this;
            myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(36.713001, 3.178525), Xamarin.Forms.Maps.Distance.FromKilometers(10000)));
            var locator = CrossGeolocator.Current;
            if (SelectMap == 1)
            {
                locator.DesiredAccuracy = 10;
            }
            Task.Run(async () => {
                position = await locator.GetPositionAsync();
                SelectMap = 0;
                // await StartListening();
                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => {
                    myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Xamarin.Forms.Maps.Distance.FromMiles(1)));
                    var pin = new Pin
                    {
                        Position = new Position(position.Latitude, position.Longitude),
                        Label = "أنت هنا !",
                    };
                    myMap.Pins.Add(pin);
                    AffichePin();
                });
            });
        }

        // obtenir consament la location
        async Task StartListening()
        {
            if (CrossGeolocator.Current.IsListening)
                return;
            if (SelectMap == 1)
            {
                CrossGeolocator.Current.DesiredAccuracy = 10;
            }
            await CrossGeolocator.Current.StartListeningAsync(TimeSpan.FromSeconds(3), 5, true);

            CrossGeolocator.Current.PositionChanged += PositionChanged;
        }

        private void PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            if (SelectMap == 1)
            {
                CrossGeolocator.Current.DesiredAccuracy = 10;
            }
            Plugin.Geolocator.Abstractions.Position tmp = position;
            position = e.Position;
            var pin = new Pin
            {
                Position = new Position(position.Latitude, position.Longitude),
                Label = "أنت هنا !",
            };
            if (SelectMap == 0)
            {
                myMap.Pins.Clear();
                myMap.Pins.Add(pin);
            }
            else if (SelectMap == 1)
            {
                customMap.Pins.Clear();
                customMap.Pins.Add(pin);
                customMap.Pins.Add(pindep);
                customMap.Pins.Add(pinarrive);
                customMap.RouteCoordinates.Remove(new Position(tmp.Latitude, tmp.Longitude));
                customMap.RouteCoordinates.Add(new Position(position.Latitude, position.Longitude));
            }
            if (Application.Current.Properties.ContainsKey("Lat"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Lat"]);
                double y = Convert.ToDouble(Application.Current.Properties["Long"]);
                var pin3 = new Pin
                {
                    Position = new Position(x, y),
                    Label = "هذه خيمتك ",
                };
                if (SelectMap == 0)
                {
                    myMap.Pins.Add(pin3);
                }
                else
                {
                    customMap.Pins.Add(pin3);
                }
            }
        }
        public async void cccv()
        {
            if (position != null)
            {
                customMap.MapType = MapType.Street;
                double x = Convert.ToDouble(Application.Current.Properties["Lat"]);
                double y = Convert.ToDouble(Application.Current.Properties["Long"]);

                var z = position.Latitude.ToString();
                var u = position.Longitude.ToString();
                var r = x.ToString();
                var t = y.ToString();
                z = z.Replace(",", ".");
                u = u.Replace(",", ".");
                r = r.Replace(",", ".");
                t = t.Replace(",", ".");
                string Liink = "https://roads.googleapis.com/v1/snapToRoads?path=";
                string hh = "&interpolate=true&key=";
                string h = "";
                string Link = "https://maps.googleapis.com/maps/api/directions/json?origin=" + z + "," + u + "&destination=" + r + "," + t + "&mode=walking&key=AIzaSyC8szME3rrsgdeGTSqaYPG-TLgIBWIwVGQ";
                if (CrossConnectivity.Current.IsConnected)
                {
                    var content = await _client.GetStringAsync(Link);
                    var tr = JsonConvert.DeserializeObject<RootObject1>(content);
                    var sr = tr.routes;
                    if (sr == null)
                    {
                        await DisplayAlert(" error ", " An error occured, please try again ! ", "OK");
                    }
                    else
                    {
                        Debug.WriteLine(Link);
                        var temps1 = position.Latitude.ToString().Replace(",", ".");
                        var temps2 = position.Longitude.ToString().Replace(",", ".");
                        h = h + temps1 + "," + temps2 + "|";
                        for (int k = 0; k < sr.Count; k++)
                        {
                            var pr = sr[k].legs;
                            if (pr != null)
                            {
                                for (int j = 0; j < pr.Count; j++)
                                {
                                    var nr = pr[j].steps;
                                    if (nr != null)
                                    {
                                        for (int i = 0; i < nr.Count; i++)
                                        {
                                            var latit = nr[i].start_location.lat.ToString().Replace(",", ".");
                                            var longi = nr[i].start_location.lng.ToString().Replace(",", ".");
                                            h = h + latit + "," + longi + "|";
                                            latit = nr[i].end_location.lat.ToString().Replace(",", ".");
                                            longi = nr[i].end_location.lng.ToString().Replace(",", ".");
                                            h = h + latit + "," + longi + "|";
                                        }
                                    }
                                }
                            }
                        }
                        temps1 = x.ToString().Replace(",", ".");
                        temps2 = y.ToString().Replace(",", ".");
                        h = h + temps1 + "," + temps2;
                        Debug.WriteLine(h);
                        var Link2 = Liink + h + hh;
                        Debug.WriteLine(Link2);
                        content = await _client.GetStringAsync(Link2);
                        var kr = JsonConvert.DeserializeObject<RootObject>(content);
                        var mr = kr.snappedPoints;
                        if (mr == null)
                        {
                            await DisplayAlert(" error ", " An error occured, please try again ! ", "OK");
                        }
                        else
                        {
                            customMap.RouteCoordinates.Add(new Position(position.Latitude, position.Longitude));
                            for (int k = 0; k < mr.Count; k++)
                            {
                                customMap.RouteCoordinates.Add(new Position(mr[k].location.latitude, mr[k].location.longitude));
                            }
                            customMap.RouteCoordinates.Add(new Position(x, y));
                        }
                    }
                }
                else
                {
                    await DisplayAlert(" error ", " An error occured, please try again ! ", "OK");
                }
                customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Xamarin.Forms.Maps.Distance.FromMeters(200)));
                var tmp1 = position.Latitude;
                var tmp2 = position.Longitude;
                pindep = new Pin
                {
                    Position = new Position(tmp1, tmp2),
                    Label = "Point de départ ",
                };
                pinarrive = new Pin
                {
                    Position = new Position(x, y),
                    Label = "هذه خيمتك",
                };
                customMap.Pins.Add(pindep);
                customMap.Pins.Add(pinarrive);
                AffichePin();
                //  MasterDetailPage1.Instance.IsPresented = true;
                Content = customMap;
                // MasterDetailPage1.Instance.IsVisible = true;
                SelectMap = 1;
                //await StartListening();
            }
            else
            {
                await DisplayAlert("انتظر .. ", "انتظر حتى يمكننا الحصول على موقعك!", "OK");
            }
        }

        public void AffichePin()
        {
            var pin = new Pin
            {
                Position = new Position(position.Latitude, position.Longitude),
                Label = "أنت هنا !",
            };
            myMap.Pins.Add(pin);
            if (Application.Current.Properties.ContainsKey("Latbut1") && Application.Current.Properties.ContainsKey("Longbut1"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Latbut1"]);
                double y = Convert.ToDouble(Application.Current.Properties["Longbut1"]);
                var z = Application.Current.Properties["Tente1"].ToString();
                Pin1 = new Pin
                {
                    Position = new Position(x, y),
                    Label = z,
                };
                myMap.Pins.Add(Pin1);
            }
            if (Application.Current.Properties.ContainsKey("Latbut2") && Application.Current.Properties.ContainsKey("Longbut2"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Latbut2"]);
                double y = Convert.ToDouble(Application.Current.Properties["Longbut2"]);
                var z = Application.Current.Properties["Tente2"].ToString();
                Pin2 = new Pin
                {
                    Position = new Position(x, y),
                    Label = z,
                };
                myMap.Pins.Add(Pin2);
            }
            if (Application.Current.Properties.ContainsKey("Latbut3") && Application.Current.Properties.ContainsKey("Longbut3"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Latbut3"]);
                double y = Convert.ToDouble(Application.Current.Properties["Longbut3"]);
                var z = Application.Current.Properties["Tente3"].ToString();
                Pin3 = new Pin
                {
                    Position = new Position(x, y),
                    Label = z,
                };
                myMap.Pins.Add(Pin3);
            }
            if (Application.Current.Properties.ContainsKey("Latbut4") && Application.Current.Properties.ContainsKey("Longbut4"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Latbut4"]);
                double y = Convert.ToDouble(Application.Current.Properties["Longbut4"]);
                var z = Application.Current.Properties["Tente4"].ToString();
                Pin4 = new Pin
                {
                    Position = new Position(x, y),
                    Label = z,
                };
                myMap.Pins.Add(Pin4);
            }
            if (Application.Current.Properties.ContainsKey("Latbut5") && Application.Current.Properties.ContainsKey("Longbut5"))
            {
                double x = Convert.ToDouble(Application.Current.Properties["Latbut5"]);
                double y = Convert.ToDouble(Application.Current.Properties["Longbut5"]);
                var z = Application.Current.Properties["Tente5"].ToString();
                Pin5 = new Pin
                {
                    Position = new Position(x, y),
                    Label = z,
                };
                myMap.Pins.Add(Pin5);
            }

        }

    }
}
