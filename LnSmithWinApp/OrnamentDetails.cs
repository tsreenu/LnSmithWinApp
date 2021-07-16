using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LnSmithWinApp
{
    public class OrnamentDetails
    {
        public int Id { get; set; }
        public string Ornament { get; set; }
       
        public int Quantity { get; set; }
       
        public decimal GrossWeight { get; set; }
        public decimal StoneWeight { get; set; }
        public decimal Quality { get; set; }
      
        public decimal NetWeight { get; set; }
    
        public decimal MarketPrice { get; set; }
        
    }
}
