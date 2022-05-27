﻿using IRepository_DB;
using Microsoft.Extensions.DependencyInjection;
using Repository_DB;
using Util;

namespace BaseDB
{
    internal class ModuleInitializer : IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, EntityFrameworkUnitOfWork>();
        }
    }
}