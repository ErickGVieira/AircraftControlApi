//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sanegeo.Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aeronave
    {
        public string PREFIX { get; set; }
        public decimal MAX_DEPARTURE_WEIGHT { get; set; }
        public decimal MAX_LANDING_WEIGHT { get; set; }
        public bool ACTIVE { get; set; }
        public string AIRCRAFT_MODEL { get; set; }
        public Nullable<int> PASSENGERS_COUNT_AIRCRAFT { get; set; }
        public int ID { get; set; }
    }
}
