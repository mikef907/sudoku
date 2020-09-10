﻿using System;
using System.Collections.Generic;
using Sudoku_UI.ViewModels;
using Sudoku_UI.Views;
using Xamarin.Forms;

namespace Sudoku_UI
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Sudoku), typeof(Sudoku));
        }

    }
}