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
    
    public partial class NAT_Curso
    {
        public int IDCurso { get; set; }
        public int IDNivel { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public int PagarCada { get; set; }
        public int IDLocalidad { get; set; }
        public int IDProfesor { get; set; }
        public int NumeroPagos { get; set; }
        public double PorcentajeMora { get; set; }
        public double PorcentajeProntoPago { get; set; }
    }
}
