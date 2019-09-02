using Dapper;
using Domain;
using Infrastructure.Data.Interface;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infrastructure.Data.Postgres
{
	public class Direcciones : IDataEntity
	{
		private readonly string _connstring;
		public Direcciones(string connstring)
		{
			_connstring = connstring;
		}
		
		public static IDbConnection OpenConnection(string connStr)
		{
			var conn = new NpgsqlConnection(connStr);
			conn.Open();
			return conn;
		}

		public void Add()
		{
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<object> Get()
		{
			IEnumerable<object> direcciones = null;

			using (var conection = OpenConnection(_connstring))
			{
				direcciones =(IEnumerable<object>) conection.Query<Direccion>("select * from direcciones");
			}
			return direcciones;
		}



		public void Update()
		{
			throw new NotImplementedException();
		}
	}
}
