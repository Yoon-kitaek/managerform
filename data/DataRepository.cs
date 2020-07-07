using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    public static class DataRepository
    {
        public static SeatData Seat { get; } = new SeatData();
        public static CustomerData Customer { get; } = new CustomerData();
        public static ProductData Product { get; } = new ProductData();
        
    }
}
