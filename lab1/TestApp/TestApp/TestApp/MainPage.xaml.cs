using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Refresh(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text.Text))
            {
                lbl.Text = "Witaj " + text.Text;
                text.Text = "";
            }
            else
            {
                DisplayAlert("Błąd", "Pole jest puste", "Ok");
                lbl.Text = "Uzupełnij pole";
            }
        }
    }
}
