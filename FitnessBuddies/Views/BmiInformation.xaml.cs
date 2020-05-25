using System;
using System.Collections.Generic;
using FitnessBuddiesDL;
using Xamarin.Forms;

namespace FitnessBuddies.Views
{
    public partial class BmiInformation : ContentPage
    {
        FitnessBuddiesClient client = new FitnessBuddiesClient();

        public BmiInformation()
        {
            InitializeComponent();
        }

        public void GetBmiInfo ()
        {



        }
    }
}
