using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace JewelryWorkshop.Data
{
    public class Material
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public int PricePerGram { get; set; }

        public override string ToString()
        {
            return Name;
        }
        
    }
}