using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin.XamlApp.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage(string userName)
        {
            InitializeComponent();
            lblMessage.Text = lblMessage.Text + userName;
            //btnBackButton.Clicked += BackButton_Clicked;
        }

        void BackButton_Clicked(object sender,EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
