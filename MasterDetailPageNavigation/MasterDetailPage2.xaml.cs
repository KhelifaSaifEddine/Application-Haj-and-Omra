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
    public partial class MasterDetailPage2 : MasterDetailPage
    {
        public MasterDetailPage2()
        {
            InitializeComponent();

            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage2MenuItem;
            if (item == null)
                return;
            switch (item.Idf)
            {
                case 0: MasterDetailPage2Detail.x = 614 - 004; break;
                case 1: MasterDetailPage2Detail.x = 614 - 005; break;
                case 2: MasterDetailPage2Detail.x = 614 - 053; break;
                case 3: MasterDetailPage2Detail.x = 614 - 080; break;
                case 4: MasterDetailPage2Detail.x = 614 - 109; break;
                case 5: MasterDetailPage2Detail.x = 614 - 131; break;
                case 6: MasterDetailPage2Detail.x = 614 - 154; break;
                case 7: MasterDetailPage2Detail.x = 614 - 180; break;
                case 8: MasterDetailPage2Detail.x = 614 - 190; break;
                case 9: MasterDetailPage2Detail.x = 614 - 211; break;
                case 10: MasterDetailPage2Detail.x = 614 - 224; break;
                case 11: MasterDetailPage2Detail.x = 614 - 238; break;
                case 12: MasterDetailPage2Detail.x = 614 - 252; break;
                case 13: MasterDetailPage2Detail.x = 614 - 258; break;
                case 14: MasterDetailPage2Detail.x = 614 - 265; break;
                case 15: MasterDetailPage2Detail.x = 614 - 270; break;
                case 16: MasterDetailPage2Detail.x = 614 - 285; break;
                case 17: MasterDetailPage2Detail.x = 614 - 296; break;
                case 18: MasterDetailPage2Detail.x = 614 - 308; break;
                case 19: MasterDetailPage2Detail.x = 614 - 315; break;
                case 20: MasterDetailPage2Detail.x = 614 - 325; break;
                case 21: MasterDetailPage2Detail.x = 614 - 335; break;
                case 22: MasterDetailPage2Detail.x = 614 - 345; break;
                case 23: MasterDetailPage2Detail.x = 614 - 353; break;
                case 24: MasterDetailPage2Detail.x = 614 - 362; break;
                case 25: MasterDetailPage2Detail.x = 614 - 370; break;
                case 26: MasterDetailPage2Detail.x = 614 - 380; break;
                case 27: MasterDetailPage2Detail.x = 614 - 388; break;
                case 28: MasterDetailPage2Detail.x = 614 - 399; break;
                case 29: MasterDetailPage2Detail.x = 614 - 407; break;
                case 30: MasterDetailPage2Detail.x = 614 - 414; break;
                case 31: MasterDetailPage2Detail.x = 614 - 418; break;
                case 32: MasterDetailPage2Detail.x = 614 - 421; break;
                case 33: MasterDetailPage2Detail.x = 614 - 431; break;
                case 34: MasterDetailPage2Detail.x = 614 - 437; break;
                case 35: MasterDetailPage2Detail.x = 614 - 443; break;
                case 36: MasterDetailPage2Detail.x = 614 - 449; break;
                case 37: MasterDetailPage2Detail.x = 614 - 456; break;
                case 38: MasterDetailPage2Detail.x = 614 - 461; break;
                case 39: MasterDetailPage2Detail.x = 614 - 470; break;
                case 40: MasterDetailPage2Detail.x = 614 - 480; break;
                case 41: MasterDetailPage2Detail.x = 614 - 486; break;
                case 42: MasterDetailPage2Detail.x = 614 - 492; break;
                case 43: MasterDetailPage2Detail.x = 614 - 499; break;
                case 44: MasterDetailPage2Detail.x = 614 - 502; break;
                case 45: MasterDetailPage2Detail.x = 614 - 505; break;
                case 46: MasterDetailPage2Detail.x = 614 - 510; break;
                case 47: MasterDetailPage2Detail.x = 614 - 514; break;
                case 48: MasterDetailPage2Detail.x = 614 - 518; break;
                case 49: MasterDetailPage2Detail.x = 614 - 521; break;
                case 50: MasterDetailPage2Detail.x = 614 - 524; break;
                case 51: MasterDetailPage2Detail.x = 614 - 526; break;
                case 52: MasterDetailPage2Detail.x = 614 - 529; break;
                case 53: MasterDetailPage2Detail.x = 614 - 531; break;
                case 54: MasterDetailPage2Detail.x = 614 - 534; break;
                case 55: MasterDetailPage2Detail.x = 614 - 537; break;
                case 56: MasterDetailPage2Detail.x = 614 - 540; break;
                case 57: MasterDetailPage2Detail.x = 614 - 545; break;
                case 58: MasterDetailPage2Detail.x = 614 - 548; break;
                case 59: MasterDetailPage2Detail.x = 614 - 552; break;
                case 60: MasterDetailPage2Detail.x = 614 - 554; break;
                case 61: MasterDetailPage2Detail.x = 614 - 556; break;
                case 62: MasterDetailPage2Detail.x = 614 - 557; break;
                case 63: MasterDetailPage2Detail.x = 614 - 559; break;
                case 64: MasterDetailPage2Detail.x = 614 - 561; break;
                case 65: MasterDetailPage2Detail.x = 614 - 563; break;
                case 66: MasterDetailPage2Detail.x = 614 - 565; break;
                case 67: MasterDetailPage2Detail.x = 614 - 567; break;
                case 68: MasterDetailPage2Detail.x = 614 - 569; break;
                case 69: MasterDetailPage2Detail.x = 614 - 571; break;
                case 70: MasterDetailPage2Detail.x = 614 - 573; break;
                case 71: MasterDetailPage2Detail.x = 614 - 575; break;
                case 72: MasterDetailPage2Detail.x = 614 - 577; break;
                case 73: MasterDetailPage2Detail.x = 614 - 578; break;
                case 74: MasterDetailPage2Detail.x = 614 - 580; break;
                case 75: MasterDetailPage2Detail.x = 614 - 581; break;
                case 76: MasterDetailPage2Detail.x = 614 - 583; break;
                case 77: MasterDetailPage2Detail.x = 614 - 585; break;
                case 78: MasterDetailPage2Detail.x = 614 - 586; break;
                case 79: MasterDetailPage2Detail.x = 614 - 588; break;
                case 80: MasterDetailPage2Detail.x = 614 - 589; break;
                case 81: MasterDetailPage2Detail.x = 614 - 590; break;
                case 82: MasterDetailPage2Detail.x = 614 - 590; break;
                case 83: MasterDetailPage2Detail.x = 614 - 592; break;
                case 84: MasterDetailPage2Detail.x = 614 - 593; break;
                case 85: MasterDetailPage2Detail.x = 614 - 594; break;
                case 86: MasterDetailPage2Detail.x = 614 - 594; break;
                case 87: MasterDetailPage2Detail.x = 614 - 595; break;
                case 88: MasterDetailPage2Detail.x = 614 - 596; break;
                case 89: MasterDetailPage2Detail.x = 614 - 597; break;
                case 90: MasterDetailPage2Detail.x = 614 - 598; break;
                case 91: MasterDetailPage2Detail.x = 614 - 598; break;
                case 92: MasterDetailPage2Detail.x = 614 - 599; break;
                case 93: MasterDetailPage2Detail.x = 614 - 599; break;
                case 94: MasterDetailPage2Detail.x = 614 - 600; break;
                case 95: MasterDetailPage2Detail.x = 614 - 600; break;
                case 96: MasterDetailPage2Detail.x = 614 - 601; break;
                case 97: MasterDetailPage2Detail.x = 614 - 601; break;
                case 98: MasterDetailPage2Detail.x = 614 - 602; break;
                case 99: MasterDetailPage2Detail.x = 614 - 602; break;
                case 100: MasterDetailPage2Detail.x = 614 - 603; break;
                case 101: MasterDetailPage2Detail.x = 614 - 603; break;
                case 102: MasterDetailPage2Detail.x = 614 - 604; break;
                case 103: MasterDetailPage2Detail.x = 614 - 604; break;
                case 104: MasterDetailPage2Detail.x = 614 - 604; break;
                case 105: MasterDetailPage2Detail.x = 614 - 605; break;
                case 106: MasterDetailPage2Detail.x = 614 - 605; break;
                case 107: MasterDetailPage2Detail.x = 614 - 605; break;
                case 108: MasterDetailPage2Detail.x = 614 - 606; break;
                case 109: MasterDetailPage2Detail.x = 614 - 606; break;
                case 110: MasterDetailPage2Detail.x = 614 - 606; break;
                case 111: MasterDetailPage2Detail.x = 614 - 607; break;
                case 112: MasterDetailPage2Detail.x = 614 - 607; break;
                case 113: MasterDetailPage2Detail.x = 614 - 607; break;
                default:
                    MasterDetailPage2Detail.x = 614; break;
            }
            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;
        
            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}