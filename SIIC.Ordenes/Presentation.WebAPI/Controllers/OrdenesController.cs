using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenesController : ControllerBase
    {

		// GET api/values
		[HttpGet]
		public JsonResult Get()
		{
			var application = new OrdenesDistribucion();
			try
			{
				var lista = application.ObtenerListadoOrdenes();
				return new JsonResult(lista);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
			
		}
	}
}