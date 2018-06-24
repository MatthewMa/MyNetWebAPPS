using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvite.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product> productEnum) {
            decimal total = 0M;
            foreach (var item in productEnum)
            {
                total += item.Price;
            }
            return total;
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> selectorParam)
        {
            foreach (Product prod in productEnum)
            {
                if (selectorParam(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
