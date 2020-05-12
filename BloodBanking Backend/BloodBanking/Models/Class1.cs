using System;
using System.Collections.Generic;

namespace BloodBanking.Models
{
    public class Region
    {
        public long Id { get; set; }
        public string Name { get; set; }
        
    }

    
    public class Bank
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public virtual Region Region { get; set; }
        public long RegionId { get; set; }
    }

    public class Donor
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public Sex Sex { get; set; }
        public string BloodType { get; set; }
        public string Phone { get; set; }
    }

    public class Donation
    {
        public long ID { get; set; }
        public DateTime DateofDonation { get; set; }
        public Donor Donor { get; set; }
        public string DonorId { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    }

    public enum BloodType
    {
        OMin,
        OPos,
        AMin,
        APos,
        BPos,
        BMin,
        ABPos,
        ABMin,
    }
}
    
