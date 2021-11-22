﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamEFCoreLab13.ViewModels;

namespace XamEFCoreLab13.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbumesPage : ContentPage
    {
        public AlbumesPage()
        {
            InitializeComponent();
            this.BindingContext = new AlbumesViewModel();
        }
    }
}