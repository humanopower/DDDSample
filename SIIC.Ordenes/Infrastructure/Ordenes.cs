using Domain;
using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
	public class Ordenes : IDataEntity
	{
		public void Add()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			this.Dispose();
		}

		public IEnumerable<Orden> Get()
		{
			var lista = new List<Orden>();
			var orden1 = new Orden();

			orden1.ID = 1;
			orden1.CompradorID = 50;
			orden1.direccion = new Direccion() { codigopostal = "Azcapotzalco", calle = "Golondrinas 57" };
			var orden2 = new Orden();
			orden2.ID = 2;
			orden2.CompradorID = 60;
			orden2.direccion = new Direccion() { codigopostal = "Naucalpan", calle = "Violetas 59" };

			var orden3 = new Orden();
			orden3.ID = 3;
			orden3.CompradorID = 70;
			orden3.direccion = new Direccion() { codigopostal = "Miguel Hidalgo", calle = "MArina NAcional 329" };
			lista.Add(orden1);
			lista.Add(orden2);
			lista.Add(orden3);
			return lista;
		}

		public IEnumerable<Direccion> GetDirecciones()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}
	}
}
