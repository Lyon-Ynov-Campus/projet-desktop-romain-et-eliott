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
using System.Xml.Linq;

namespace e_commerce_desktop
{
    /// <summary>
    /// Logique d'interaction pour Produit.xaml
    /// </summary>
    public partial class Produit : Page
    {
        public Produit(string name,string mdp)
        {
            InitializeComponent();
        }
    }
}