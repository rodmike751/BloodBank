using BloodBanking.Models;
using BloodBanking.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodBanking.ApiControllers
{
    [RoutePrefix("api/banks")]
    public class BanksController : ApiController
    {
        [HttpGet]
        [Route("getone")]
        public ReturnObject GetOne(long id)
        {
            try
            {
                var data = new BankRepository().GetOne(id);
                return new ReturnObject
                {
                    Data = data,
                    Msg = "Bank retrieved successfully",
                    Status = 1,
                    Total = 1
                };
            }
            catch (Exception e)
            {
                return new ReturnObject
                {
                    Data = null,
                    Msg = e.Message,
                    Status = 0,
                    Total = 0
                };
            }
        }
        [HttpGet]
        [Route("getall")]
        public ReturnObject GetAll()
        {
            try
            {
                var data = new BankRepository().GetAll();
                return new ReturnObject
                {
                    Data = data,
                    Msg = "Records retrieved successfully",
                    Status = 1,
                    Total = 1
                };
            }
            catch (Exception e)
            {
                return new ReturnObject
                {
                    Data = null,
                    Msg = e.Message,
                    Status = 0,
                    Total = 0
                };
            }
        }

        [HttpPost]
        [Route("create")]
        public ReturnObject Create(Bank bank)
        {
            try
            {
                var data = new BankRepository().AddBanks(bank);
                if (data != true) throw new Exception("Couldn't save the bank");
                return new ReturnObject
                {
                    Data = data,
                    Msg = "Record retrieved successfully",
                    Status = 1,
                    Total = 1
                };
            }
            catch (Exception e)
            {
                return new ReturnObject
                {
                    Data = null,
                    Msg = e.Message,
                    Status = 0,
                    Total = 0
                };
            }
        }
        [HttpPut]
        [Route("update")]
        public ReturnObject Update(Bank bank)
        {
            var data = new BankRepository().Update(bank);
            if (data != true) throw new Exception("Couldn't save the bank");
            return new ReturnObject
            {
                Data = data,
                Msg = "Retrieved successfully",
                Status = 1,
                Total = 1
            };
        }
    }
	}
