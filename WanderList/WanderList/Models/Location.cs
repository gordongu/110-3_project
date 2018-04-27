using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace WanderList.Models
{
    public class Location
    {
		public int LocationId { get; set; }
		public string Name { get; set; }
		public double Rating { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
        public string ImageLink { get; set; }
    }
}
