using Encinecarlos.FinancialManager.Application.Adapters;
using Encinecarlos.FinancialManager.Application.Categories.dto;
using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Query
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoriesDto>
    {
        private readonly IRepository<Category, Guid> _repository;

        public GetCategoryByIdHandler(IRepository<Category, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoriesDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Catgory.CategoryId);

            var categoryAdapted = CategoryAdapter.ToDto(category);

            return await Task.FromResult(categoryAdapted);
        }
    }
}
