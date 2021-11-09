using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RedPlus
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(); // <------------- �ݵ�� �����ؾ� �� razor page�� �������
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //<!-----  �̵���� �߰� ����,  ������ html, css, javascript, �̹��� ��  ���� wwwroot�� ���� ��Ƴ���
            //app.UseFileServer(); //  <--------- �̵���� �߰� ����, Ȯ���� .html�� �ν� index.html�� ���ؽ�Ű�� ����?  ���۰˻� microsoft docs usefileserver


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); // <----------------  �ݵ�� �����ؾ� �� razor page�� �������
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!!!!");
                //});
            });
        }
    }
}
