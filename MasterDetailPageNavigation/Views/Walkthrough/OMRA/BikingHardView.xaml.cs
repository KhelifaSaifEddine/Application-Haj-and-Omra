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
    public partial class BikingHardView : IAnimatedView
    {
       
        public bool Auto { get; private set; }

        public BikingHardView()
        {

            InitializeComponent();
            Auto = true;
            LottieAnimation.Play();
        }

        public void StartAnimation()
        {
            Auto = true;
            LottieAnimation.Play();
        }
        public void StopAnimation()
        {

        }
    }
}