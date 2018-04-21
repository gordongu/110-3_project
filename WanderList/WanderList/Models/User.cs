using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WanderList.Models
{
    public class User
    {       
        public int UserId { get; set; } //int
        public string UserName { get; set; } //varchar
        public string Password { get; set; } //varchar
        public int SavedLocs { get; set; } //binary()
        public int ViewedLocs { get; set; } //binary()     
    }
}
