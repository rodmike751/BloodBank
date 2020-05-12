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
    [RoutePrefix("api/donations")]
    public class DonationsController : ApiController
    {
        [HttpGet]
        [Route("getone")]

        public ReturnObject GetOne(long id)
        {
            try
            {
                var data = new DonationRepository().GetOne(id);

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
        [HttpGet]
        [Route("getall")]
        public ReturnObject GetAll()
        {
            try
            {
                var data = new DonationRepository().GetAll();

                return new ReturnObject
                {
                    Data = data,
                    Msg = "Records retrieved Sucessfully",
                    Status = 1,
                    Total = data.Count()
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
        public ReturnObject Create(Donation donation)
        {
            try
            {
                var data = new DonationRepository().AddDonations(donation);
                if (data != true) throw new Exception("Couldn't save the region");

                return new ReturnObject
                {
                    Data = null,
                    Msg = "Saved Successfully",
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
        public ReturnObject Update(Donation donation)
        {
            try
            {
                var data = new DonationRepository().Update(donation);
                if (data != true) throw new Exception("Could not update the region");

                return new ReturnObject
                {
                    Data = null,
                    Msg = "Updated Successfully",
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

        [HttpDelete]
        [Route("delete")]
        public ReturnObject Delete(long donationId)
        {
            try
            {
                var data = new DonationRepository().Delete(donationId);
                if (data != true) throw new Exception("Could not delete region");

                return new ReturnObject
                {
                    Data = null,
                    Msg = "Deleted Sucessfully",
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
    }
}


        
    

