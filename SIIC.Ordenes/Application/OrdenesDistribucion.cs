using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;

namespace Application
{
	public class OrdenesDistribucion
	{
		public void AgregarOrdenDistribucion()
		{

			
			
			
		}
		public List<Orden> ObtenerListadoOrdenes()
		{

			var infraestructuraData = new Ordenes();
				var ordenes = infraestructuraData.ObtenerOrdenes();
			
			foreach (var orden in ordenes)
			{
				orden.direccion = new Direccion();
				orden.ObtenerItemsOrden();
			
			}
			
			return ordenes;
		}

	}
}
