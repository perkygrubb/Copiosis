//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Copiosis_Application.DB_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class itemClass
    {
        public itemClass()
        {
            this.products = new HashSet<product>();
        }
    
        public int classID { get; set; }
        public string name { get; set; }
        public Nullable<int> suggestedGateway { get; set; }
        public Nullable<double> cPdb { get; set; }
        public Nullable<double> a { get; set; }
        public Nullable<int> aMax { get; set; }
        public Nullable<int> d { get; set; }
        public Nullable<int> aPrime { get; set; }
        public Nullable<double> cCb { get; set; }
        public Nullable<double> m1 { get; set; }
        public Nullable<int> pO { get; set; }
        public Nullable<double> m2 { get; set; }
        public Nullable<double> cEb { get; set; }
        public Nullable<int> s { get; set; }
        public Nullable<double> m3 { get; set; }
        public Nullable<short> sE { get; set; }
        public Nullable<double> m4 { get; set; }
        public Nullable<short> sH { get; set; }
    
        public virtual ICollection<product> products { get; set; }
    }
}
