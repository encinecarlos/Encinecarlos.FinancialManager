using Encinecarlos.FinancialManager.Application.Categories.dto;
using Encinecarlos.FinancialManager.Domain.Entities;
using Encinecarlos.FinancialManager.Domain.Interfaces;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    public class RemoveCategoryHandler : IRequestHandler<RemoveCategoryCommand, RemoveCategoryDto>
    {
        private readonly IRepository<Category, Guid> _repository;

        public RemoveCategoryHandler(IRepository<Category, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<RemoveCategoryDto> Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.RemoveAsync(request.CategoryId);
            return await Task.FromResult(new RemoveCategoryDto());
        }
    }
}
