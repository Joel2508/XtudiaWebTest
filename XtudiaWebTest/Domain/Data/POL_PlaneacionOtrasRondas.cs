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
    
    public partial class POL_PlaneacionOtrasRondas
    {
        public int IDPlaneacionOtraRonda { get; set; }
        public int IDTorneo { get; set; }
        public int Ronda { get; set; }
        public int Grupo1 { get; set; }
        public int Posicion1 { get; set; }
        public int Grupo2 { get; set; }
        public int Posicion2 { get; set; }
        public Nullable<int> IDEquipo1 { get; set; }
        public Nullable<int> IDEquipo2 { get; set; }
        public Nullable<int> GolesEquipo1 { get; set; }
        public Nullable<int> GolesEquipo2 { get; set; }
        public Nullable<int> IDEquipoPasa { get; set; }
        public string Llave { get; set; }
    }
}
