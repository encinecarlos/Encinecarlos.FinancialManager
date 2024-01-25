using Encinecarlos.FinancialManager.Application.Categories.dto;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Command
{
    public class AddCategoryCommand : IRequest<CategoryDto>
    {
        public CategoryRequest Category { get; set; }
    }
}
