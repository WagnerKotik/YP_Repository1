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
    
    public partial class Cinema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cinema()
        {
            this.Rent = new HashSet<Rent>();
        }
    
        public int IdCinema { get; set; }
        public string NameCinema { get; set; }
        public long INNCinema { get; set; }
        public string Address { get; set; }
        public string Chief { get; set; }
        public string PhoneChief { get; set; }
        public string Owner { get; set; }
        public string PhoneOwner { get; set; }
        public string Phone { get; set; }
        public string District { get; set; }
        public string BankCinema { get; set; }
        public int AccountCinema { get; set; }
        public int Capacity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rent> Rent { get; set; }
    }
}
