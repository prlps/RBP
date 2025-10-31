using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace JewelryWorkshop.Data
{
    public class Product
    {
        public int Id { get; set; } // Код изделия
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required, MaxLength(50)]
        public string Type { get; set; } = null!; // Серьги, кольцо, браслет и т.д.

        [ForeignKey("Material")]
        public int MaterialId { get; set; } // FK
        public Material? Material { get; set; }

        public double Weight { get; set; } // Вес в граммах
        public decimal Price { get; set; } // Итоговая цена

        public override string ToString()
        {
            return Name;
        }
    }
}