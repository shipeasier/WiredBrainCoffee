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
using WiredBrainCoffee.Simulators;

namespace WiredBrainCoffee.UI.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CoffeeMachine _coffeeMachine;
        public MainWindow()
        {
            InitializeComponent();
            _coffeeMachine = new CoffeeMachine();
            txtCappucinoCounter.Text = _coffeeMachine.CounterCappuccino.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _coffeeMachine.MakeCappuccino();
            txtCappucinoCounter.Text = _coffeeMachine.CounterCappuccino.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _coffeeMachine.ShowStoredState();
        }
    }
}
