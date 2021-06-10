using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeBot.Models
{
    
    public class Users : DbContext
    {
        public Users()
        {

        }
        public DbSet<Users> User { get; set; }
    }
}
