using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using web.Repository;
using Web.Models;

namespace Web.Controllers
{
    public class AdvertiseController : Controller
    {
        [HttpGet]
		[Route("advertise")]
		[EnableCors("CorsPolicy")]
		public IEnumerable<Display> Get([FromServices]IAdvertiseRepository advertise, int? sizeId)
        {
			try
			{
				return advertise.GetDisplay(sizeId);
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
