using Domain;
using Infrastructure.Data.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application
{
	public class DirecionesOrdenesDistribucion
	{
		private readonly string _constring;
		private readonly IDataEntity _dataServicePostgress;
		public DirecionesOrdenesDistribucion(string constring)
		{
			_constring = constring;
			var services = new ServiceCollection();
			services.AddScoped<IDataEntity>(s => new Infrastructure.Data.Postgres.Direcciones(_constring));
			var provider = services.BuildServiceProvider();
			_dataServicePostgress = provider.GetService<IDataEntity>();
		}

		public IEnumerable<Direccion> ObtenerDireccionesOrdenesDeSurtimiento()
		{
			var diresinCast = _dataServicePostgress.Get();
			IEnumerable<Direccion> direcciones = (IEnumerable<Direccion>)diresinCast;
			return direcciones;
		}
	}
}
