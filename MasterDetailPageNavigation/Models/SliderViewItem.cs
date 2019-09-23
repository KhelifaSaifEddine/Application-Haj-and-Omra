using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailPageNavigation.Models
{
    public class SliderViewItem
    {
        //  public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Step { get; set; }
        private bool _isChecked;
        public Boolean Check
        {
            get { return _isChecked; }
            set
            {
                _isChecked = value;

            }
        }
        //    public Xamarin.Forms.Color BackgroundColor { get; set; }


    }
}
