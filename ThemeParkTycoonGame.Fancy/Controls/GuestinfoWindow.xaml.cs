﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ThemeParkTycoonGame.Fancy.Controls
{
    /// <summary>
    /// Interaction logic for GuestinfoWindow.xaml
    /// </summary>
    public partial class GuestinfoWindow : Window
    {
        Core.Guest guest;
        public GuestinfoWindow(Core.Guest selectedGuest)
        {
            InitializeComponent();

            this.guest = selectedGuest;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Labeltje.Content = guest.Name;
        }
    }
}
