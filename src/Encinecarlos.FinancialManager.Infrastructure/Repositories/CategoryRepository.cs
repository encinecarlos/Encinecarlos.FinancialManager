using Encinecarlos.FinancialManager.Infrastructure.Data;
using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Encinecarlos.FinancialManager.Infrastructure.Repositories
{
    public class CategoryRepository : IRepository<Category, Guid>
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
            => await _context.Categories.ToListAsync();

        public async Task<Category> GetByIdAsync(Guid id) =>
            await _context.Categories.FirstOrDefaultAsync(x => x.Id == id) ?? new Category();

        public async Task RemoveAsync(Guid id)
        {
            var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public async Task SaveAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Update(category);
            await _context.SaveChangesAsync();
        }
    }
}
