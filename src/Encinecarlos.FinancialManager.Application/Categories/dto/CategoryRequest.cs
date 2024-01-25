namespace Encinecarlos.FinancialManager.Application.Categories.dto
{
    public record CategoryRequest
    {
        public string Name { get; init; }
        public string? Description { get; init; }
    }
}
