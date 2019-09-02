using Domain;
using Infrastructure;
using Infrastructure.Data.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
	public class OrdenesDistribucion : IApplication
	{
		private readonly string _conexionAplicacion;
		private readonly string _conexionPostgres;
		private readonly IDataEntity _dataServiceSql;
		public OrdenesDistribucion(string conexionAplicacion,string connecionPostgress)
		{
			_conexionAplicacion = conexionAplicacion;
			_conexionPostgres = connecionPostgress;
			var services = new ServiceCollection();
			services.AddScoped<IDataEntity>(s => new Infrastructure.Data.Ordenes(_conexionAplicacion));
			var provider = services.BuildServiceProvider();
			_dataServiceSql = provider.GetService<IDataEntity>();
		}
		public IEnumerable<object> ObtenerListadoOrdenes()
		{
			
			var ordenes = _dataServiceSql.Get();
			foreach (var ordenSinCast in ordenes)
			{
				var direccionesApp = new DirecionesOrdenesDistribucion(_conexionPostgres);
				var orden = (Orden)ordenSinCast;
				orden.direccion = direccionesApp.ObtenerDireccionesOrdenesDeSurtimiento(orden.CompradorID);
				orden.ObtenerItemsOrden();
			}
			return ordenes;
		}
		public void AgregarOrdenDistribucion()
		{
		}
		

	}
}
