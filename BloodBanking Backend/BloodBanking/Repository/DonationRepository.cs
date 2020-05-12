using BloodBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBanking.Repository
{
    public class DonationRepository
    {
        public bool AddDonations(Donation donation)
        {
            var database = new BloodBankingContext();
            if (string.IsNullOrEmpty(donation.DonorId)) return false;

            database.Donations.Add(donation);
            database.SaveChanges();
            return true;
        }

        public Donation GetOne(long id)
        {
            var db = new  BloodBankingContext();
            var donation = db.Donations.Find(id);
            if (donation == null)
                throw new Exception("Could not find Donations");
            return donation;
        }

        public List<Donation> GetAll()
        {
            var db = new BloodBankingContext();
            var donation = db.Donations.ToList();
            if (donation == null)
                throw new Exception("Couldnt find any donations");
            return donation;
        }

        public bool Update(Donation donation)
        {
            var db = new BloodBankingContext();
            var donations = db.Donations.FirstOrDefault(x => x.ID == donation.ID);
            if (donation == null) return false;
            db.SaveChanges();
            return true;
        }

        public bool Delete(long id)
        {
            var db = new BloodBankingContext();
            var donations = db.Donations.FirstOrDefault(x => x.ID == id);
            if (donations == null) return false;
            db.SaveChanges();
            return true;
        }
    }
}