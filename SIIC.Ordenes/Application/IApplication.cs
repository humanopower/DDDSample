﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
	public interface IApplication
	{
		IEnumerable<Orden> ObtenerListadoOrdenes();
	}
}