//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHE_Chequeo
    {
        public int IDChequeo { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IDCompetidor { get; set; }
        public int IDProducto { get; set; }
        public int IDUsuario { get; set; }
        public decimal Precio { get; set; }
    }
}
