using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WanderList.Models
{
	public class SavedLocation
	{
		public int id { get; set; }
		public int UserId { get; set; } //int
		public int LocationId { get; set; } //int
	}
}
