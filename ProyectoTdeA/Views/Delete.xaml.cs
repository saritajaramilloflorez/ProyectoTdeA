﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoTdeA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Delete : ContentPage
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnVolver4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Welcome());
        }
    }
}