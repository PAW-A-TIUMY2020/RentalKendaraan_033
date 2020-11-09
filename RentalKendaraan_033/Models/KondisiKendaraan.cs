using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_033.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }

        [Required(ErrorMessage = "Nama Kondisi wajib diisi")]
        public string NamaKondisi { get; set; }
    }
}
