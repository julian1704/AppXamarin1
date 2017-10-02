using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            var layout = new StackLayout();
            var label = new Label { Text = "Ingresar", };
            var entry = new Entry { Placeholder = "Nombre", };
            var button = new Button
            { Text = "Presionar", };
            button.Clicked += Button_Clicked;

            Content = layout;
            layout.Children.Add(label);
            layout.Children.Add(entry);
            layout.Children.Add(button);

            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Atención","El botón ha sido presionado","Ok");
        }

    }
 }

