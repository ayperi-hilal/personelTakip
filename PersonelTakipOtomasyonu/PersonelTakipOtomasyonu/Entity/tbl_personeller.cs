//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonelTakipOtomasyonu.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_personeller
    {
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public string email { get; set; }
        public Nullable<int> departmani { get; set; }
        public string durum { get; set; }
        public Nullable<decimal> maas { get; set; }
        public Nullable<System.DateTime> girisTarihi { get; set; }
        public Nullable<System.DateTime> cikisTarihi { get; set; }
        public string aciklama { get; set; }
    
        public virtual tbl_departmanlar tbl_departmanlar { get; set; }
    }
}
