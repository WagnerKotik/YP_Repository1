//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinoDen.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public int Id { get; set; }
        public int IdProvider { get; set; }
        public int IdFilm { get; set; }
        public System.DateTime DateBuy { get; set; }
        public decimal Summ { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Provider Provider { get; set; }
    }
}