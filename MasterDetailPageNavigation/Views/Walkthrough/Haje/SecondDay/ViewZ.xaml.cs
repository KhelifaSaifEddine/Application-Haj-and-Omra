﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Walkthrough.Views.Walkthrough;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailPageNavigation.Views.Walkthrough
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewZ : IAnimatedView
    {
		public ViewZ ()
		{
			InitializeComponent ();
            this.BindingContext = this;
            Auto = true;

            LottieAnimation.Play();

        }

        public bool Auto { get; private set; }

        public void StartAnimation()
        {
            Auto = true;
            LottieAnimation.Play();


        }
        /*    protected override void OnBindingContextChanged()
            {
                base.OnBindingContextChanged();

                Context = this.BindingContext as Mother2;


            }*/

        public void StopAnimation()
        {

        }
    }
}