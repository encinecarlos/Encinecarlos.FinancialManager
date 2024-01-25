using Encinecarlos.FinancialManager.Application.Categories.dto;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    public class UpdateCategoryCommand : IRequest<UpdateCategoryDto>
    {
        public Guid CategoryId { get; set; }
        public CategoryRequest Category { get; set; }
    }
}
