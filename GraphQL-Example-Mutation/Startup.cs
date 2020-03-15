using GraphQL_Examples.Models;
using GraphQL_Examples.Schema;
using HotChocolate;
using HotChocolate.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQL_Examples
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Store>();

            services.AddGraphQL(
                SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .AddType<CustomerType>()
                .AddType<ItemType>()
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var store = app.ApplicationServices.GetService<Store>();

            store.AddCustomer(new Customer
            {
                Id = 42,
                Firstname = "Joscha",
                Lastname = "Hemlep",
                Comment = "Can be extremely annoying"
            });

            app.UseRouting();

            app.UseGraphQL()
                .UsePlayground();
        }
    }
}