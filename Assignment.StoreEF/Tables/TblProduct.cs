using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreEF.Tables
{
    public class TblProduct
    {
        public long ProductId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public long CategoryId { get; set; }

        public virtual TblCategory Category { get; set; } = null!;
    }
}
