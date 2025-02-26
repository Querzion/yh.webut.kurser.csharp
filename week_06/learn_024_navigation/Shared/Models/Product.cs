using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Product
    {
        public string ArticleNumber { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
