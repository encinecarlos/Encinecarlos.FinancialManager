using Encinecarlos.FinancialManager.Application.Categories.dto;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    public class RemoveCategoryCommand : IRequest<RemoveCategoryDto>
    {
        public Guid CategoryId { get; set; }
    }
}
