using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web_953506_Bortnovskiy.Data;
using Web_953506_Bortnovskiy.Entities;

[assembly: HostingStartup(typeof(Web_953506_Bortnovskiy.Areas.Identity.IdentityHostingStartup))]
namespace Web_953506_Bortnovskiy.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}