using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazingShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Imagen { get; set; } = String.Empty;

        [Column(TypeName="decimal(18,2")]
        public decimal price { get; set; }

    }
}
