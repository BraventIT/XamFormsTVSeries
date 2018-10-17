﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsTVSeries.ViewModels;

namespace XamFormsTVSeries.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailView : ContentPage
    {
        private DetailViewModel _vm; 
        public DetailView(DetailViewModel detailvm)
        {
            InitializeComponent();
            this.BindingContext = detailvm;
            Task.Run(async () => await detailvm.Init());
        }
    }
}