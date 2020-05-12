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
    [RoutePrefix("api/donors")]
    public class DonorsController : ApiController
    {
        [HttpGet]
        [Route("getone")]
        public ReturnObject GetOne(long id)
        {
            try
            {
                var data = new DonorsRepository().GetOne();
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

        [HttpGet]
        [Route("getall")]
        public ReturnObject GetAll()
        {
            try
            {
                var data = new DonorsRepository().GetAll();

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
        public ReturnObject Create(Donor donor)
        {
            try
            {
                var data = new DonorsRepository().AddDonor(donor);
                if (data != true) throw new Exception("Couldn't save the donor");

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
        public ReturnObject Update(Donor donor)
        {
            try
            {
                var data = new DonorsRepository().Update(donor);
                if (data != true) throw new Exception("Could not update the donor");

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
        public ReturnObject Delete(long donorId)
        {
            try
            {
                var data = new DonorsRepository().Delete(donorId);
                if (data != true) throw new Exception("Could not delete donor");

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

    