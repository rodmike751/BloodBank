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
    [RoutePrefix("api/regions")]
    public class RegionsController : ApiController
    {
        [HttpGet]
        [Route("getone")]
        public ReturnObject GetOne(long id)
        {
            try
            {
                var data = new RegionRepository().GetOne(id);

                return new ReturnObject
                {
                    Data = data,
                    Msg = "Recored retrieved Successfully",
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
                var data = new RegionRepository().GetAll();

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
        public ReturnObject Create(Region region)
        {
            try
            {
                var data = new RegionRepository().AddRegion(region);
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
        public ReturnObject Update(Region region)
        {
            try
            {
                var data = new RegionRepository().Update(region);
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
        public ReturnObject Delete(long regionId)
        {
            try
            { var data = new RegionRepository().Delete(regionId);
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
        
