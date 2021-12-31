using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ListView1
{
    public partial class MainPage : ContentPage
    {
        public class Fruta
        {
            public string Nombre { get; set; }
            public string Url { get; set; }
        }
        ObservableCollection<Fruta> datos = new ObservableCollection<Fruta>();
        public MainPage()
        {
            InitializeComponent();
            milista.ItemsSource = datos;
        }
        //

        private void Button_Clicked(object sender, EventArgs e)
        {
            datos.Add(new Fruta { Nombre = valor.Text, Url = direccionurl.Text });
            valor.Text = "";
            direccionurl.Text = "";
        }
        private void MenuItem_Mostrar(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Seleccionó Mostrar", "ok");
        }
        private void MenuItem_Borrar(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Fruta seleccioada", "Fruta:" +
           mi.CommandParameter.ToString(), "ok");


        }
        async private void Milista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem;
            int index = datos.IndexOf(myItem);
            string action = await DisplayActionSheet("Acciones:", "Cancelar",
           null, "Eliminar", "Editar");
            if (action == "Eliminar")
            {
                datos.RemoveAt(index);
                await DisplayAlert("Eliminar elemento", "Se elimino el elemento No: "
               + index, "OK");
                milista.ItemsSource = null;
                milista.ItemsSource = datos;
            }
            if (action == "Editar")
            {
                await DisplayAlert("Mensaje", "Seleccionó editar", "ok");
            }
        }
    }
}
