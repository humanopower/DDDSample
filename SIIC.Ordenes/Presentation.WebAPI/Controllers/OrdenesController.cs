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
		private readonly IApplication _application;
		public OrdenesController(IApplication application)
		{
			_application = application;
		}
		// GET api/values
		[HttpGet]
		public JsonResult Get()
		{
			
			try
			{
				var lista = _application.ObtenerListadoOrdenes();
				return new JsonResult(lista);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			
			
		}
	}
}