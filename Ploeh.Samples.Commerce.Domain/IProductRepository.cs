using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.Commerce.Domain
{
    public interface IProductRepository
    {
         IEnumerable<Product> GetFeaturedProducts();
    }
}
