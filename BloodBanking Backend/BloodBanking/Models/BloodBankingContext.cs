using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodBanking.Models
{
    public class BloodBankingContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BloodBankingContext() : base("name=BloodBankingContext")
        {
        }

        public System.Data.Entity.DbSet<BloodBanking.Models.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<BloodBanking.Models.Donation> Donations { get; set; }

        public System.Data.Entity.DbSet<BloodBanking.Models.Donor> Donors { get; set; }

        public System.Data.Entity.DbSet<BloodBanking.Models.Bank> Banks { get; set; }
    }
}
