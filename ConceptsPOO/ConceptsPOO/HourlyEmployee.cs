using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class HourlyEmployee : Employee
    {
        public float Hour { get; set; }

        public decimal HourValue { get; set; }
        public override decimal GetValueToPay()
        {
            return (decimal)Hour * HourValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tHours................: {$"{Hour:n2}",18} " +
                $"\n\tHours Value..........: {$"{HourValue:c2}",18} " +
                $"\n\tvalue to pay:........: {$"{GetValueToPay():c2}",18} ";
        }
    }
}
