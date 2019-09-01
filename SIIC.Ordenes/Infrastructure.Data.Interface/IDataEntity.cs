using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Interface
{
	public interface IDataEntity
	{
		IEnumerable<Orden> Get();
		IEnumerable<Direccion> GetDirecciones();

		void Add();
		void Delete();
		void Update();
	}
}
