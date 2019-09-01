using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
	public class OrdenesDistribucion : IApplication
	{
		private readonly string _conexionAplicacion;
		private readonly string _conexionPostgres;
		public OrdenesDistribucion(string conexionAplicacion,string connecionPostgress)
		{
			_conexionAplicacion = conexionAplicacion;
			_conexionPostgres = connecionPostgress;
		}
		public IEnumerable<Orden> ObtenerListadoOrdenes()
		{
			
			string connstring = _conexionAplicacion;

			var infraestructuraData = new Infrastructure.Data.Ordenes(connstring);
			var ordenes = infraestructuraData.Get();
			foreach (var orden in ordenes)
			{
				var direccionesApp = new DirecionesOrdenesDistribucion(_conexionPostgres);
				orden.direccion = direccionesApp.ObtenerDireccionesOrdenesDeSurtimiento().ToList()[0];
				orden.ObtenerItemsOrden();
			}
			return ordenes;
		}
		public void AgregarOrdenDistribucion()
		{
		}
		

	}
}
