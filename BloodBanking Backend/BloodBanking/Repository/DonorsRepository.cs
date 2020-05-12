using BloodBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBanking.Repository
{
    public class DonorsRepository
    {
        public bool AddDonor(Donor donor)
        {
            var database = new BloodBankingContext();
            if (string.IsNullOrEmpty(donor.Name)) return false;

            database.Donors.Add(donor);
            database.SaveChanges();
            return true;
        }

        public Donor GetOne()
        {
            var db = new BloodBankingContext();
            var donor = db.Donors.Find();
            if (donor == null)
                throw new Exception("Couldn't find Donor");
            return donor;
        }

        public List<Donor> GetAll()
        {
            var db = new BloodBankingContext();
            var donor = db.Donors.ToList();
            if (donor == null)
                throw new Exception("Couldn't find Donor");
            return donor;
        }
        
        public bool Update (Donor donor)
        {
            var db = new BloodBankingContext();
            var donors = db.Donors.FirstOrDefault(x => x.ID == donor.ID);
            if (donor == null)
                db.SaveChanges();
            return true;
        }

        public bool Delete (long id)
        {
            var db = new BloodBankingContext();
            var donors = db.Donors.FirstOrDefault(x => x.ID == id);
            if (donors == null)
            db.Donors.Remove(donors);
            db.SaveChanges();
            return true;
        }
    }

}