//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Perputakaan
{
    using System;
    using System.Collections.Generic;
    
    public partial class buku
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buku()
        {
            this.pinjams = new HashSet<pinjam>();
        }
    
        public string id { get; set; }
        public string gambar { get; set; }
        public string judul { get; set; }
        public string penerbit { get; set; }
        public string pengarang { get; set; }
        public System.DateTime tahun_terbit { get; set; }
        public System.DateTime tahun_pengadaan { get; set; }
        public int jumlah { get; set; }
        public int dipinjam { get; set; }
        public int hilang { get; set; }
        public int rusak { get; set; }
        public string lokasi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pinjam> pinjams { get; set; }
    }
}
