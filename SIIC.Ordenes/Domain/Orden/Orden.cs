using System;
using System.Collections.Generic;

namespace Domain.Orden
{
	/// <summary>
	/// Se refiere a la clase dominio entidad Orden de surtimiento de producto
	/// https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/microservice-domain-model
	/// </summary>
	public class Orden : EntidadBase
	{
		#region Atributos
		
		public int CompradorID { get; set; }
		public string NombreComprador { get; set; }
		public string dbOrigen { get; set; }
		public Direccion direccion { get; set; }
		public List<OrdenItem> OrdenItems { get; set; }

		#endregion
		#region Metodos
		public Orden()
		{

			this.OrdenItems = new List<OrdenItem>();
			this.direccion = new Direccion();
		}
		public void AgregarOrdenItem(OrdenItem item)
		{
			OrdenItems.Add(item);
		}
		public void EstablecerDireccion(Direccion direccion)
		{ }

		public void CalculaTotal()
		{ }

		public void ObtenerItemsOrden()
		{

			var item = new OrdenItem();
			var randomNumber = new Random(3000);
			item.ID = randomNumber.Next();
			item.ProductId = randomNumber.Next();
			item.Precio = randomNumber.Next();
			this.OrdenItems.Add(item);
		}
		#endregion
	}
}
