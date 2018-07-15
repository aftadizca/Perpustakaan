using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perputakaan
{
    public static class UpdateStok
    {
        public static void pinjam(string idbuku)
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var buku = db.bukus.First(i=> i.id==idbuku);
                buku.dipinjam++;
                db.SaveChanges();
            }
        }

        public static void kembali(string idbuku)
        {
            using (perpustakaanEntities db = new perpustakaanEntities())
            {
                var buku = db.bukus.First(i => i.id == idbuku);
                if(buku.dipinjam != 0)
                {
                    buku.dipinjam--;
                    db.SaveChanges();
                }
            }
        }
    }
}
