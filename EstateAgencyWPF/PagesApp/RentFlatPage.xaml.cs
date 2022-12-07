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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EstateAgencyWPF.PagesApp
{
    /// <summary>
    /// Interaction logic for RentFlatPage.xaml
    /// </summary>
    public partial class RentFlatPage : Page
    {
        public RentFlatPage()
        {
            InitializeComponent();
            LViewFlats.ItemsSource = App.Connection.FlatBase.Where(z => z.Type == 2).ToList();
        }
    }
}
