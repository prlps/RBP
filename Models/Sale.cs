using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace JewelryWorkshop.Data
{
    public class Sale
    {
        public int Id { get; set; } // Код продажи
        [ForeignKey("Product")]
        public int ProductId { get; set; } // FK
        public Product? Product { get; set; }

        public DateTime SaleDate { get; set; }
        [Required]
        public string LastName { get; set; } = null!;
        [Required, MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string? MiddleName { get; set; } // Отчество
    }
}