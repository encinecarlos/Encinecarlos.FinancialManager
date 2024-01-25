using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using Encinecarlos.FinancialManager.Infrastructure.Data;
using Encinecarlos.FinancialManager.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Encinecarlos.FinancialManager.Api.Extensions
{
    public static class PersistenceExtension
    {
        public static void AddPersistenceContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>();

            services.AddScoped<IRepository<Category, Guid>, CategoryRepository>();
        }
    }
}
