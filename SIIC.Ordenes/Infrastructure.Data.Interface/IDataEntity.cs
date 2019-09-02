using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Interface
{
	public interface IDataEntity
	{
		IEnumerable<object> Get();
	

		void Add();
		void Delete();
		void Update();
	}
}
