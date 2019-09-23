
// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

using FFImageLoading.Forms.Platform;

namespace MasterDetailPageNavigation.UWP
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
             CachedImageRenderer.Init();
            Xamarin.FormsMaps.Init("Aik4R6nsDo1-7URid3KPAvQWeWlX8hjDOmhWot0vOVoIBypbjsLOwIxta1dOtzc-");
            Rg.Plugins.Popup.Popup.Init();
            LoadApplication(new MasterDetailPageNavigation.App());
        }
    }
}
