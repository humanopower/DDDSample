using Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Interface
{
	public interface IDataEntity
	{
		/// <summary>
		/// MEtodo que devuelve un listado  de tipo objeto, que tendrá que aplicarle un cast para poder revisar contenido.
		/// </summary>
		/// <returns></returns>
		IEnumerable<object> Get();
	
		/// <summary>
		/// MEtodo que permite agregar un objeto a la base de datos
		/// </summary>
		void Add();
		/// <summary>
		/// Metodo que permite eliminar un objeto en la persistencia de la base de datos.
		/// </summary>
		
		void Delete();
		/// <summary>
		/// Metodo que permite actualizar un registro en la base de datos.
		/// </summary>
		void Update();
	}
}
