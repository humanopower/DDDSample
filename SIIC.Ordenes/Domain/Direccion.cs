using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
	/// <summary>
	/// Esta clase es un tipo value object porque no tiene identificador
	/// </summary>
	public class Direccion
	{
		public string Calle { get; set; }
		public string Ciudad { get; set; }
	}
}
