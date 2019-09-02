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
		public string calle { get; set; }
		public string codigopostal { get; set; }
		public int compradorid { get; set; }
		public string dborigen { get; set; }
	}
}
