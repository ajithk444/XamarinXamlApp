    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.XamlApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public const double AppBorderWidth = 3.0;
        public static string LoggedInUserName = "rsak90";
        public MainPage()
        {
            
            InitializeComponent();
            btn_Login.Clicked += Handle_Clicked;
            txt_Username.TextChanged += Handle_TextChanged;
        }

        void Handle_Clicked(Object sender, EventArgs e)
        {
            LoggedInUserName = "ajithk444";
            txt_Username.Text = LoggedInUserName;
            Debug.WriteLine("Clicked by : " + txt_Username.Text + " | "+btn_Login.BorderWidth);
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if (txt_Username.Text!=null && txt_Username.Text.Length > 0)
            {
                btn_Login.IsEnabled = true;
            }
        }
    }
}
