﻿namespace Encinecarlos.FinancialManager.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; init; }
        public string Description { get; init; }
    }
}
