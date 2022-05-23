using IService_Domain;
using Microsoft.Extensions.DependencyInjection;
using Service_Domain.Services;
using Util;

namespace Service_Domain
{
    class ModuleInitializer : IModuleInitializer
    {
        public void Initialize(IServiceCollection services)
        {
            services.AddScoped<IDomainService_Account, DomainService_Account>();
            services.AddScoped<IDomainService_Menu, DomainService_Menu>();
            services.AddScoped<IDomainService_Organization, DomainService_Organization>();
            services.AddScoped<IDomainService_People, DomainService_People>();
            services.AddScoped<IDomainService_Role, DomainService_Role>();
        }
    }
}