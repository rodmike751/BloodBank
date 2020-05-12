using BloodBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BloodBanking.Repository
{
    public class BankRepository
    {
        public bool AddBanks(Bank bank)
        {
            var database = new BloodBankingContext();
            if (string.IsNullOrEmpty(bank.Name)) return false;

            database.Banks.Add(bank);
            database.SaveChanges();
            return true;
        }
        public Bank GetOne(long id)
        {
        var db = new BloodBankingContext();
          var bank = db.Banks.Find(id);
           if (bank == null)
                throw new Exception("Could not find Bank");
            return bank;
        }
        public List<Bank> GetAll()
        {
            var db = new BloodBankingContext();
            var Bank = db.Banks.ToList();
            if (Bank == null)
                throw new Exception("Could not find Bank");
            return Bank;

        }
        public bool Update(Bank bank)
        {
            var db = new BloodBankingContext();
            var banks = db.Banks.FirstOrDefault(x => x.Id == bank.Id);
            if (bank == null) return false;
            bank.Name = bank.Name;
            return true;
        }
        public bool Delete(Bank bank)
        {
            var db = new BloodBankingContext();
            var banks = db.Banks.FirstOrDefault(x => x.Id == bank.Id);
            if (bank == null) return false;
            db.Banks.Remove(bank);
            db.SaveChanges();
            return true;
        }
    }
}