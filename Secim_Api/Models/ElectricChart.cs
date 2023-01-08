using System.Collections.Generic;
using System.Threading;

namespace Secim_Api.Models
{
    public class ElectricChart
    {
        public ElectricChart()
        {
            Counts = new List<int>();
        }
        public string ElectricDate { get; set; }
        public List<int> Counts { get; set; }
    }
}
