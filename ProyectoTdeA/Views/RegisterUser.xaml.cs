using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoTdeA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterUser : ContentPage
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnVolver2_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Edit_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Edit());
        }

        private void eliminar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Delete());
        }
    }
}