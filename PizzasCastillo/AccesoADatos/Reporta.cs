//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reporta
    {
        public int IdReporte { get; set; }
        public string CodigoBarra { get; set; }
        public decimal CantidadEnInventario { get; set; }
        public decimal CantidadReal { get; set; }
        public string Comentario { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual ReporteInventario ReporteInventario { get; set; }
    }
}
