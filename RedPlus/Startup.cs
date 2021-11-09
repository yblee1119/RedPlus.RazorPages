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
            services.AddRazorPages(); // <------------- 반드시 삽입해야 함 razor page를 만들려면
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //<!-----  미들웨어 추가 정의,  정적인 html, css, javascript, 이미지 등  폴더 wwwroot를 만들어서 모아놓음
            //app.UseFileServer(); //  <--------- 미들웨어 추가 정의, 확장자 .html을 인식 index.html을 이해시키기 위함?  구글검색 microsoft docs usefileserver


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); // <----------------  반드시 삽입해야 함 razor page를 만들려면
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!!!!");
                //});
            });
        }
    }
}
