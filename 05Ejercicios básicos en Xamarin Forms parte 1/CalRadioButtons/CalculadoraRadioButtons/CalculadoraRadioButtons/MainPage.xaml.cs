using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraRadioButtons
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
                float a = float.Parse(valor1.Text);
                float b = float.Parse(valor2.Text);
                float c;
                switch (operacion.SelectedIndex)
                {
                    case -1:
                        {

                            resultado.Text = "No selecciono ninguna operacion";
                            break;
                        }
                    case 0:
                        {
                            c = a + b;
                            resultado.Text = a + "+" + b + "=" + c;
                            break;
                        }
                    case 1:
                        {
                            c = a - b;
                            resultado.Text = a + "-" + b + "=" + c;
                            break;
                        }
                    case 2:
                        {
                            c = a * b;
                            resultado.Text = a + "x" + b + "=" + c;
                            break;
                        }
                    case 3:
                        {
                            c = a / b;
                            resultado.Text = a + "/" + b + "=" + c;
                            break;
                        }
                }
            }
            catch (Exception)
            {
                resultado.Text = "Error";
            }
        }
    }
}
