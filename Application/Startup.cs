using MediatR;
using System.Reflection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
	public class Startup : object
	{
		public Startup
			(Microsoft.Extensions.Configuration.IConfiguration configuration) : base()
		{
			Configuration = configuration;
		}

		public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }

		public void ConfigureServices
			(Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			services.AddControllers();

			// Note:
			// using MediatR;
			//services.AddMediatR
			//	(handlerAssemblyMarkerTypes: typeof(Startup));

			// Note:
			// using MediatR;
			// using System.Reflection;
			services.AddMediatR
				(assemblies: typeof(Startup).GetTypeInfo().Assembly);
		}

		public void Configure
			(Microsoft.AspNetCore.Builder.IApplicationBuilder app,
			Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");

				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();

				//	endpoints.MapControllerRoute
				//	(
				//		name: "default",
				//		pattern: "{controller=Home}/{action=Index}/{id?}"
				//	);
			});
		}
	}
}
