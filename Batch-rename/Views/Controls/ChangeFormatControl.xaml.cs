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
using BatchRename.Models;
using StringLibrary;
namespace BatchRename.Views.Controls
{
    /// <summary>
    /// Interaction logic for NewCaseControl.xaml
    /// </summary>
    public partial class ChangeFormatControl : UserControl
    {
        public ChangeFormatControl()
        {
            DataContext = ViewModel;
            InitializeComponent();
        }

        public FunctionChangeFormat ViewModel { get; set; } = new FunctionChangeFormat();

        private void OnShowResult(object sender, RoutedEventArgs e)
        {
            try
            {
                tbResult.Text = ViewModel.GetString(tbInput.Text);
                tbResult.IsEnabled = true;
            }
            catch (Exception)
            {
                tbResult.Text = "invalid input!";
                tbResult.IsEnabled = false;
            }
        }
    }
}