using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using web.Repository;
using Web.Models;

namespace Web.Controllers
{
    public class AdvertiseController : Controller
    {
        [HttpGet]
		[Route("advertise")]
		public IEnumerable<Display> Get([FromServices]IAdvertiseRepository advertise, int? sizeId, int? aspectRatio)
        {
			try
			{
				return advertise.GetDisplay(sizeId, aspectRatio);
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
