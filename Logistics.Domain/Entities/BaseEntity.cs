﻿namespace Logistica.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTimeOffset? DateCreated { get; set; }
        public DateTimeOffset? DateUpdated { get; set; }
        public DateTimeOffset? DateDeleted { get; set; }
    }
}