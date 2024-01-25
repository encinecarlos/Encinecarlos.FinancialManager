using Encinecarlos.FinancialManager.Application.Adapters;
using Encinecarlos.FinancialManager.Application.Categories.dto;
using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, UpdateCategoryDto>
    {
        private readonly IRepository<Category, Guid> _repository;

        public UpdateCategoryHandler(IRepository<Category, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<UpdateCategoryDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = CategoryAdapter.ToEntity(request.CategoryId, request.Category);
            await _repository.UpdateAsync(category);
            return await Task.FromResult(new UpdateCategoryDto());
        }
    }
}
