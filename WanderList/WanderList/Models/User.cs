using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WanderList.Models
{
    public class User
    {       
        public int UserId { get; set; } //int
        public string UserName { get; set; } //varchar
        public string Password { get; set; } //varchar
        public string Email { get; set; }
        Location[] SavedLocations { get; set; } //binary()
        Location[] ViewedArrays { get; set; } //binary()     
    }
}
