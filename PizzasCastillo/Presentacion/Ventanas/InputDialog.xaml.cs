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

namespace Presentacion.Ventanas
{
    /// <summary>
    /// Lógica de interacción para InputDialog.xaml
    /// </summary>
    public partial class InputDialog : Window
    {
        public InputDialog(string titulo)
        {
            InitializeComponent();
            tituloVentana.Text = titulo;
        }
        public string ResponseText
        {
            get { return respuesta.Text; }
            set { respuesta.Text = value; }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
