using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel4_PBO.Model
{
    public class Transaksi
    {
        public string id_transaksi { get; set; }
        public string id_karyawan { get; set; }
        public int total_transaksi { get; set; }
        public DateTime tanggal { get; set; }

    }

}
