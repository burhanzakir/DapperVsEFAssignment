using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.StoreEF.Tables
{
    public class TblCategory
    {
        public TblCategory()
        {
            TblProducts = new HashSet<TblProduct>();
        }

        public long CategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<TblProduct> TblProducts { get; set; }
    }
}
