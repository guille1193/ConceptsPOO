using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Invoice : Ipay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }


        public decimal Getvaluetopay()
        {
            return Price * (decimal)Quantity;
        }
        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tQuantity.......: {$"{Quantity:N2}",18}" +
                $"\n\tPrice..........: {$"{Price:C2}",18}" +
                $"\n\tValue..........: {$"{Getvaluetopay():C2}",18}";              ;
        }
    }
}
