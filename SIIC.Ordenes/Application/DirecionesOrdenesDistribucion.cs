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
		private readonly string _connstring;
		private readonly IDataEntity _dataServicePostgress;
		public DirecionesOrdenesDistribucion(string constring)
		{
			_connstring = constring;
			var services = new ServiceCollection();
			services.AddScoped<IDataEntity>(s => new Infrastructure.Data.Postgres.Direcciones(_connstring));
			var provider = services.BuildServiceProvider();
			_dataServicePostgress = provider.GetService<IDataEntity>();
		}

		public Direccion ObtenerDireccionesOrdenesDeSurtimiento(int compradorId)
		{
			Direccion direccion =(_dataServicePostgress.Get() as List<Direccion>).Find(p => p.compradorid == compradorId);
			return direccion;
		}
	}
}
