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
    public partial class MasterDetailPage2Detail : CarouselPage
    {
        public static int x;
        public MasterDetailPage2Detail()
        {
            InitializeComponent();
           
            this.CurrentPage = this.Children[x];
        }
    }
}