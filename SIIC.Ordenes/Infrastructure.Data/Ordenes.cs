using Dapper;
using Domain;
using Infrastructure.Data.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Infrastructure.Data
{
	public class Ordenes : IDataEntity
	{
		private readonly string _connstring;
		public Ordenes(string connstring)
		{
			_connstring = connstring;
		}
		public void Add()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Orden> Get()
		{
			IEnumerable<Orden> ordenes= null;
			using (var conection = new SqlConnection(_connstring))
			{
				ordenes = conection.Query<Orden>("select * from Ordenes");
			}
			return ordenes;
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
