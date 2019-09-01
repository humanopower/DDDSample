using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
	public class DirecionesOrdenesDistribucion
	{
		private readonly string _constring;
		public DirecionesOrdenesDistribucion(string constring)
		{
			_constring = constring;
		}

		public IEnumerable<Direccion> ObtenerDireccionesOrdenesDeSurtimiento()
		{

			var infraestructuraData = new Infrastructure.Data.Postgres.Direcciones(_constring);
			IEnumerable<Direccion> direcciones = infraestructuraData.GetDirecciones();
			
			return direcciones;
		}
	}
}
