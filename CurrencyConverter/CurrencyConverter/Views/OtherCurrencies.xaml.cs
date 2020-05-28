using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrencyConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OtherCurrencies : ContentPage
    {
        public OtherCurrencies()
        {
            MessagingCenter.Subscribe<MainPage, string[]>(this, "MessageName", (sender, args) =>
            {
                LbUSD.Text = args[0];
                LbEUR.Text = args[1];
                LbJPY.Text = args[2];
                LbGBP.Text = args[3];
                LbAUD.Text = args[4];
                LbCAD.Text = args[5];
                LbCHF.Text = args[6];
                LbCNY.Text = args[7];
                LbSEK.Text = args[8];
                LbNZD.Text = args[9];

                topName.Text = "Top 10 najważniejszych walut dla " + args[10];
            });

            InitializeComponent();
            

        }
    }     
}