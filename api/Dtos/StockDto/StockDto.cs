using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.StockDto
{
    public class StockDto
    {
        public int ID    { get; set; }
        public String Symbol { get; set; } = String.Empty;
        public string CompanyName { get; set; } = String.Empty ;


        public decimal Purchase { get;set;}

        public decimal LastDiv { get;set;}

        public String Industry { get; set; } = String.Empty;

        public long Marketcap { get; set; }
    }
}