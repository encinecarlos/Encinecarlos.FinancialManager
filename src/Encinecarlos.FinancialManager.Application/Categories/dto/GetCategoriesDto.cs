namespace Encinecarlos.FinancialManager.Application.Categories.dto
{
    public class GetCategoriesDto
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
