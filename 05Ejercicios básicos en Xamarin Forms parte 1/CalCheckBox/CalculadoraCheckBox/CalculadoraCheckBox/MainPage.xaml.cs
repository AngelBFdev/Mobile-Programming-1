using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraCheckBox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                String s = "";
                float a = float.Parse(valor1.Text);
                float b = float.Parse(valor2.Text);
                if (check1.IsChecked == true)
                {
                    s = s + a + "+" + b + "=" + (a + b) + "\n";
                }
                if (check2.IsChecked == true)
                {
                    s = s + a + "-" + b + "=" + (a - b) + "\n";
                }
                resultado.Text = s;
            }
            catch
            {
                resultado.Text = "Valores invalidos!!";
            }
        }
    }
}
