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
    public partial class Edit : ContentPage
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btnVolver3_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}