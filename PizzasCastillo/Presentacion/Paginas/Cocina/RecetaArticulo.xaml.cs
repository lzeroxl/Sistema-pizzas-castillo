﻿using AccesoADatos.ControladoresDeDatos;
using Dominio.Entidades;
using Presentacion.Ventanas;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Presentacion.Paginas.Cocina
{
    /// <summary>
    /// Lógica de interacción para RecetaArticulo.xaml
    /// </summary>
    public partial class RecetaArticulo : Page
    {
        public RecetaArticulo(ArticuloVenta platilloEdicion)
        {
            InitializeComponent();
            PlatilloDAO platilloDAO = new PlatilloDAO();
            AccesoADatos.Platillo platillo = platilloDAO.ObtenerPlatillo(platilloEdicion.CodigoBarra);
            if (platillo == null)
            {
                InteraccionUsuario ventana = new InteraccionUsuario("Error", "Este articulo no cuenta con una receta debido a que no es un platillo");
                ventana.Show();
                recetaText.Text = "Esto no es un platillo no existe receta";
            }
            else
            {
                recetaText.Text = platillo.Receta;
            }
        }

        private void Regresar(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
