using CurrencyConverter.Helper;
using CurrencyConverter.Model;
using CurrencyConverter.Views;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CurrencyConverter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {  
        public MainPage()
        {
            InitializeComponent();           
           
        }

       
        private string Currency = "PLN";
       
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
       
        private async void Button_Clicked(object sender, EventArgs e)
        {   

            string text = entry1.Text;
            double d1 = double.Parse(text);

            Currency = Picker1.SelectedItem.ToString();

            string[] LabelList = new string[10];

            var url = $"http://api.ratesapi.io/api/latest?base={Currency}";

            var result = await ApiCaller.Get(url);
            double wynik = 0.0;

            if (result.Successful)
            {
                try
                {                   
                    var currencyInfo = JsonConvert.DeserializeObject<Rootobject>(result.Response);
                    if (Picker1.SelectedItem.ToString() == "EUR")
                    {
                        wynik = d1 * 1.0;
                        LabelList[1] = "1.00 " + Picker1.SelectedItem.ToString();
                    }
                    else
                    {
                        wynik = d1 * double.Parse(GetPropValue(currencyInfo.rates, Picker2.SelectedItem.ToString()).ToString());
                        LabelList[1] = (1.0 / currencyInfo.rates.EUR).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    }
                 
                    LabelList[0] = (1.0 / currencyInfo.rates.USD).ToString("0.00") + " " + Picker1.SelectedItem.ToString();                 
                    LabelList[2] = (1.0 / currencyInfo.rates.JPY).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[3] = (1.0 / currencyInfo.rates.GBP).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[4] = (1.0 / currencyInfo.rates.AUD).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[5] = (1.0 / currencyInfo.rates.CAD).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[6] = (1.0 / currencyInfo.rates.CHF).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[7] = (1.0 / currencyInfo.rates.CNY).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[8] = (1.0 / currencyInfo.rates.SEK).ToString("0.00") + " " + Picker1.SelectedItem.ToString();
                    LabelList[9] = (1.0 / currencyInfo.rates.NZD).ToString("0.00") + " " + Picker1.SelectedItem.ToString();

                    MessagingCenter.Send<MainPage, string[]>(this, "MessageName", LabelList);

                    

                    wynikLb.Text = wynik.ToString("0.00") + " " + Picker2.SelectedItem.ToString();



                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Weather Info", "No weather information found", "OK");
            }
        }

        
        //    public async Task<List<string>> GetItemsAsync(int pageIndex, int pageSize)
        //    {
        //        await Task.Delay(1000);





        //        return _data.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        //    }
    }
}