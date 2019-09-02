using Infrastructure.Data.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
	public static class InfrastructureInjection
	{
		
		public static IServiceCollection AddDependencyServices(this IServiceCollection services)
		{
			services.AddScoped<IDataEntity, Infrastructure.Data.Postgres.Direcciones>();
		
			return services;
		}
	}
}
