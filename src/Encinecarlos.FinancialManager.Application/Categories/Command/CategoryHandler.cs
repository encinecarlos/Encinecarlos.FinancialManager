using Encinecarlos.FinancialManager.Application.Adapters;
using Encinecarlos.FinancialManager.Application.Categories.dto;
using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    internal class CategoryHandler : IRequestHandler<AddCategoryCommand, CategoryDto>
    {
        private readonly IRepository<Category, Guid> _repository;

        public CategoryHandler(IRepository<Category, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<CategoryDto> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = CategoryAdapter.ToEntity(request.Category);
            await _repository.SaveAsync(category);

            var categoryId = CategoryAdapter.ToCategoryDto(category);

            return await Task.FromResult(categoryId);
        }
    }
}
