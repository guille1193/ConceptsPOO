using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        public float CommissionPercentaje { get; set; }

        public decimal Sales { get; set; }   
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommission Percentaje: {$"{CommissionPercentaje:p2}", 18} " +
                $"\n\tSales................: {$"{Sales:c2}", 18} " +
                $"\n\tvalue to pay:........: {$"{GetValueToPay():c2}",18} ";
        }
    }
}
