using BloodBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBanking.Repository
{
    public class RegionRepository
    {
        public bool AddRegion(Region reg)
        {
            var database = new BloodBankingContext();
            if (string.IsNullOrEmpty(reg.Name)) return false;

            database.Regions.Add(reg);
            database.SaveChanges();
            return true;
        }

        public Region GetOne(long id)
        {
            var db = new BloodBankingContext();
            var region = db.Regions.Find(id);
            if (region == null)
                throw new Exception("Could not find region");
            return region;

        }

        public List<Region> GetAll()
        {
            var db = new BloodBankingContext();
            var region = db.Regions.ToList();
            if (region == null)
                throw new Exception("Could not find any region");
            return region;

        }

        public bool Update(Region reg)
        {
            var db = new BloodBankingContext();
            var region = db.Regions.FirstOrDefault(x => x.Id == reg.Id);        
            if (region == null) return false;
            region.Name = reg.Name;
            db.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var db = new BloodBankingContext();
            var region = db.Regions.FirstOrDefault(x => x.Id == id);
            if (region == null) return false;
            db.Regions.Remove(region);
            db.SaveChanges();
            return true;
        }
    }
}

