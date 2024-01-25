using Encinecarlos.FinancialManager.Application.Categories.dto;
using MediatR;

namespace Encinecarlos.FinancialManager.Application.Categories.Query
{
    public class GetCategoriesQuery : IRequest<IEnumerable<GetCategoriesDto>>
    {
        public GetCategoriesRequest? Filters { get; set; }
    }
}
