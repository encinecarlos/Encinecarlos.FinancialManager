using Encinecarlos.FinancialManager.Application.Categories.dto;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Query
{
    public class GetCategoryByIdQuery : IRequest<GetCategoriesDto>
    {
        public GetCategoryByIdRequest Catgory { get; set; }
    }
}
